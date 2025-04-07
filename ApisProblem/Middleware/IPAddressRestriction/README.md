# 🔐 IP Restriction Middleware in ASP.NET Core

This project demonstrates how to implement a **custom middleware** in ASP.NET Core to restrict access to an application based on a list of allowed IP addresses.

## 📌 Problem Statement

You are building an internal API or admin panel that must only be accessible from a set of **trusted IP addresses** (such as internal network addresses). Any request from an unrecognized IP address should be rejected with a `403 Forbidden` status code.

## 🚀 Features

- ✅ Custom ASP.NET Core middleware
- ✅ IP address checking from `HttpContext.Connection.RemoteIpAddress`
- ✅ Logs all incoming IPs and blocked attempts
- ✅ Configurable allowed IP list via `appsettings.json`

## 🔧 Setup Instructions

1. **Clone the repo** and open it in your favorite IDE.

2. **Configure allowed IPs** in `appsettings.json`:

```json
"AllowedIPs": [
  "127.0.0.1",
  "::1"
]

```
