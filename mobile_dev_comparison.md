# 📊 Mobile Development Platforms Comparison

This document compares the programming languages, IDEs, SDKs, libraries, and frameworks used for **Android**, **iOS**, **Tizen**, and **.NET (Cross-Platform)** development.

---

## Side-by-Side Comparison

| **Platform** | **Primary Languages** | **Official IDEs / Tools** | **SDKs** | **Libraries & Frameworks** | **Notes** |
|--------------|------------------------|----------------------------|----------|-----------------------------|-----------|
| **Android** | - Java<br>- Kotlin (modern official)<br>- C/C++ (via NDK) | - **Android Studio** (official)<br>- IntelliJ IDEA (alt)<br>- VS Code (with plugins) | - **Android SDK** (APIs, tools)<br>- Android NDK (for native C/C++) | - Jetpack (modern Android libraries)<br>- AndroidX<br>- Material Components<br>- Firebase SDK | Kotlin is now the recommended language by Google. |
| **iOS** | - Swift (modern official)<br>- Objective-C (legacy)<br>- C/C++ (low-level) | - **Xcode** (official)<br>- AppCode (JetBrains, alt) | - **iOS SDK** (with Xcode)<br>- Swift Package Manager (SPM) | - UIKit (UI)<br>- SwiftUI (modern declarative UI)<br>- Core Data, Core ML, ARKit<br>- Cocoa Touch Frameworks | Swift + SwiftUI is the current Apple direction. |
| **Tizen (Samsung OS)** | - C# (preferred)<br>- C<br>- C++ | - **Visual Studio with Tizen Extension** (for .NET apps)<br>- Tizen Studio (for native) | - **Tizen SDK** (native & .NET APIs)<br>- Tizen .NET SDK (Xamarin-based) | - TizenFX (.NET)<br>- Native API (C)<br>- Xamarin.Forms (UI for .NET apps) | Runs on wearables, TVs, appliances. Xamarin.Forms (now .NET MAUI) supports Tizen. |
| **.NET (Cross-Platform)** | - C# (main)<br>- F#<br>- VB.NET | - **Visual Studio** (Windows, Mac)<br>- Rider (JetBrains)<br>- VS Code | - **.NET SDK** (.NET Core / .NET 5+)<br>- Mono / Xamarin SDK (mobile) | - **.NET MAUI** (new Xamarin.Forms)<br>- ASP.NET Core (web)<br>- Entity Framework Core<br>- Blazor (web UI) | .NET MAUI allows single codebase apps for Android, iOS, Windows, macOS. |

---

## 🔑 Key Takeaways

1. **Android**: Best with **Kotlin + Android Studio**.  
2. **iOS**: Best with **Swift + Xcode**.  
3. **Tizen**: Uses **C# with Xamarin/.NET** for cross-platform or **C for native**.  
4. **.NET Cross-Platform**: **C# + .NET MAUI** (one codebase for Android, iOS, Windows, macOS).  

---
