# 🌐 .NET MAUI (Multi-platform App UI)

## 📌 What is .NET MAUI?
- **.NET MAUI** = **cross-platform framework** by Microsoft.  
- Write a **single C# + XAML codebase**, run it on **Android, iOS, Windows, and macOS**.  
- It is the **evolution of Xamarin.Forms**.  

---

## ✅ Capabilities

- **Cross-Platform UI**: Build once, deploy to Android, iOS, Windows, macOS.  
- **Native Access**: Access device hardware (camera, GPS, sensors).  
- **MVU & MVVM Support**: Works with **Model-View-Update** (C# UI) and **MVVM** (XAML UI).  
- **Blazor Hybrid**: Combine web UI (Blazor components) with native app features.  
- **Hot Reload**: Instantly see UI/code changes while debugging.  
- **Performance**: Uses **.NET 6/7/8 runtime** → faster than Xamarin.  
- **Shared Resources**: Share fonts, images, styles, and resources across platforms.  

---

## 🛠 IDEs for .NET MAUI

| **IDE** | **Supported OS** | **Notes** |
|---------|------------------|-----------|
| **Visual Studio 2022/2025 (Windows)** | Windows | Full MAUI support (Android, iOS, Windows, macOS). |
| **Visual Studio 2022/2025 for Mac** | macOS | MAUI support, but limited compared to Windows. |
| **VS Code (with Extensions)** | Windows/macOS/Linux | Works with CLI & plugins, not as integrated as Visual Studio. |

---

## 🖥 Simulator vs Emulator

| **Aspect** | **Simulator** | **Emulator** |
|------------|---------------|---------------|
| **What it is** | A **software replica** of the device OS (mimics UI & behavior, not hardware). | A **virtualized version of the real device hardware + OS**. |
| **Speed** | Faster (since it doesn’t emulate hardware, only software behavior). | Slower (emulates CPU, GPU, RAM → closer to real device performance). |
| **Accuracy** | Less accurate for hardware testing (e.g., GPS, sensors, battery). | More accurate (tests hardware + software, almost like a real device). |
| **Common Use** | Apple’s **iOS Simulator** (runs only on macOS). | Android Emulator, Tizen Emulator (hardware-level testing). |
| **Resource Usage** | Lighter on system resources. | Heavy, needs CPU & RAM. |

---

## ⚡ In Practice
- For **iOS**, you usually use the **iOS Simulator** (fast, but limited hardware tests).  
- For **Android/Tizen**, you often use **Emulators** (closer to real devices).  
- For final verification → always test on **physical devices**.  
