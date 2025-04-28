# AES-256 Encryption/Decryption Module

## Overview

This utility provides **AES-256** symmetric encryption and decryption using a pre-shared key. It securely handles:

- Key derivation (SHA-256 hashing of the raw key)
- IV (Initialization Vector) generation and embedding
- Base64 encoding for ciphertext transport

## Usage

### Basic Usage

### Encryption

```csharp
string plainText = "Hello, World!";
string encryptedText = AesEncryption.Encrypt(plainText);
// Output: Base64-encoded ciphertext (IV + encrypted data)
```

### Decryption

```csharp
string decryptedText = AesEncryption.Decrypt(encryptedText);
// Output: Original plaintext
```

## Key Features

### Automatic IV Handling

- Generates a new IV for each encryption
- Prepends IV to ciphertext for secure storage/transmission

### Key Security

- Uses SHA-256 to derive a 256-bit key from your input key
- Default key: `"MySecureKey123"` (**change in production!**)

### Data Integrity

- Throws `ArgumentException` for malformed ciphertext
- Validates minimum ciphertext length (16 bytes for IV)

---

## Implementation Details

### Encryption Flow

1. Derive 256-bit key using SHA-256
2. Generate random IV
3. Write IV + AES-encrypted data to memory stream
4. Return Base64-encoded result

### Decryption Flow

1. Decode Base64 ciphertext
2. Extract first 16 bytes as IV
3. Decrypt remaining data using the IV
4. Return original UTF-8 string

---

## Security Notes

⚠️ **Important**:

- Always use a **strong secret key** in production (not the default!)
- Store keys securely (e.g., environment variables/key vaults)
- IVs should be unique for each encryption
