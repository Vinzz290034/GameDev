# Paranormal Investigation (Working Title)

A small-scale, highly optimized 3D co-op multiplayer horror game built for mobile and desktop platforms. Players work in teams to investigate supernatural phenomena, gather evidence using specialized tools, and survive dynamic paranormal threats.

---

## Project Overview

* **Engine:** Unity 6 (`6000.6.4f1`) — Universal Render Pipeline (URP)
* **Target Platforms:** Mobile (Android / iOS) & PC
* **Genre:** Multiplayer Horror / Co-op
* **Sub-Genre:** Paranormal Investigation
* **Networking Architecture:** Photon Fusion 2 (Host / Shared Mode)
* **Target Launch:** August 2027

---

## Team Roster & Ownership

| Name | Role | Primary Focus |
| :--- | :--- | :--- |
| **Vince** | Lead & Gameplay Engineer | Core player controller, touch responsiveness, interaction logic, and sprint coordination. |
| **Marc** | Multiplayer / Network Engineer | Matchmaking/lobbies, relay synchronization, latency handling, and disconnect/reconnect logic. |
| **Christ, Vince, Marc** | Tech Art & Optimization | Mobile shaders, dynamic lighting budget, draw call batching, LODs, and device profiling. |
| **Christian, Christ** | 3D Generalist & Animator | Low-poly modular kits, prop texturing, entity/survivor models, and rigging/animations. |
| **Christian, Christ** | Level Design & Audio | Level layout, pacing, scare triggers, spatial 3D audio, and touch UI/HUD UX. |

---

## 10-Month Master Production Roadmap

| Timeline | Phase | Core Deliverables | Exit Gate Criteria |
| :--- | :--- | :--- | :--- |
| **Oct – Dec 2026** | **Prototype & Netcode** | Movement sync, room matchmaking, touch controls, and core threat loop with graybox primitives. | 60 FPS on baseline mobile devices; stable room connection. |
| **Jan 2027** | **First Playable** | Complete 10–12 min match loop, interactive tools framework, and server-driven entity AI. | Zero critical desyncs; under 30-min thermal limit. |
| **Feb – Mar 2027** | **Vertical Slice** | Map 1 production-ready with final art, lighting pass, spatial audio, and HUD. | Build size < 500 MB; RAM footprint < 1.2 GB. |
| **Apr – May 2027** | **Content & Alpha** | Map 2 production, randomized variants, and external closed alpha testing (50–100 players). | **Hard feature freeze (May 15).** Stability focus only. |
| **Jun – Jul 2027** | **Soft Launch & Tuning**| Regional test release, telemetry/crash monitoring, and store optimization (ASO). | Crash-free sessions > 98.5%; Day 1 retention measured. |
| **Aug 2027** | **Global Release** | Worldwide launch on Google Play & App Store, live-ops hotfixes, and scaling. | Public store release. |

---

## Getting Started (Contributor Setup)

### Prerequisites
1. **Unity Hub:** Download and install the latest [Unity Hub](https://unity.com/download).
2. **Unity Editor:** Install the exact matching version: **`Unity 6 (6000.6.4f1)`**.
   * *Required Modules:* **Android Build Support** (with OpenJDK and Android SDK & NDK tools) and **iOS Build Support** (if building on macOS).
3. **Git LFS:** Make sure Git Large File Storage is installed on your machine:
   ```bash
   git lfs install
