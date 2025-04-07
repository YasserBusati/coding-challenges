# 🧱 Request Timeout Restriction Middleware

You want to enforce a maximum execution time for HTTP requests. If a request takes too long (e.g. over 5 seconds), you want to automatically cancel it and return a 408 Request Timeout response to the client. This can help protect your app from long-running or hanging requests.

---

## 🛠 Features

- Configurable request timeout via `appsettings.json`.
- Gracefully cancels long-running requests.
- Returns proper `408` with a user-friendly message.
- Logs timing out endpoints for debugging.

---

## 🔧 Configuration

The timeout value is defined in `appsettings.json`:

```json
{
  "TimeoutOptions": {
    "RequestTimeoutInSeconds": 5
  }
}
```
