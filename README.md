# Paranormal Investigation (Working Title)

A high-performance 3D paranormal horror game built for mobile and PC platforms. The game features both a narrative-driven **Single-Player Story Campaign** and an intense **Co-op Multiplayer Investigation Mode**, built on a unified networking and gameplay architecture.

---

## Game Modes

* **Single-Player (Story Campaign):** A narrative-driven investigation featuring scripted paranormal phenomena, environmental storytelling, puzzle-solving, and entity evasion.
* **Co-op Multiplayer (Investigation Ops):** 2–4 players cooperate in procedural investigation contracts, coordinating specialized equipment to identify entities, gather evidence, and survive hostile hunts.
* **Architectural Principle:** Story Mode executes on the same Photon Fusion game loop as multiplayer (configured as a private single-client session with full local authority). All tools, entity interactions, and mechanics share a single, unified codebase.

---

## Project Overview

* **Engine:** Unity 6 (`6000.6.4f1`) — Universal Render Pipeline (URP)
* **Target Platforms:** Mobile (Android / iOS) & PC
* **Genre:** Psychological Horror / Paranormal Investigation
* **Networking Architecture:** Photon Fusion 2 (Host / Shared Mode)
* **Target Launch:** August 2027

---

## Team Roster & Ownership

| Name | Role | Primary Focus |
| :--- | :--- | :--- |
| **Vince** | Lead & Gameplay Engineer | Core player controller, touch UI input, interaction framework, story triggers, and sprint coordination. |
| **Marc** | Multiplayer / Network Engineer | Matchmaking, lobby system, room state sync, session isolation (Single-Player vs. Multi), and latency compensation. |
| **Christ, Vince, Marc** | Tech Art & Optimization | Mobile URP shaders, dynamic shadow budgets, occlusion culling, draw call batching, and device profiling. |
| **Christian, Christ** | 3D Generalist & Animator | Modular environment kits, narrative props, entity/survivor models, and rigging/animations. |
| **Christian, Christ** | Level Design & Audio | Level layout, scare pacing, story trigger sequences, spatial 3D audio cues, and HUD UX. |

---

## 10-Month Master Production Roadmap

| Timeline | Phase | Core Deliverables | Exit Gate Criteria |
| :--- | :--- | :--- | :--- |
| **Oct – Dec 2026** | **Prototype & Netcode** | Unified movement sync, room code lobby, touch controls, and basic threat loop in a graybox environment. | 60 FPS on baseline mobile; flawless local single-player & 2-player sync. |
| **Jan 2027** | **First Playable** | Complete 10–12 min multiplayer contract loop + playable Story Prologue chapter with linear objective triggers. | Zero critical desyncs; under 30-min mobile thermal throttling limit. |
| **Feb – Mar 2027** | **Vertical Slice** | Map 1 production-ready (shared by Story & Co-op), final lighting pass, spatial audio, and inventory UI. | Build size < 500 MB; RAM footprint < 1.2 GB. |
| **Apr – May 2027** | **Content & Alpha** | Map 2 production, Story Chapters 1–2, entity variants, and closed external alpha test (50–100 players). | **Hard feature freeze (May 15).** Bug fixes, performance tuning, and polish only. |
| **Jun – Jul 2027** | **Soft Launch & Tuning**| Regional store release, crash/telemetry tracking, and App Store Optimization (ASO). | Crash-free sessions > 98.5%; Day 1 retention targets met. |
| **Aug 2027** | **Global Release** | Worldwide release on Google Play & App Store, live-ops hotfixes, and server scaling. | Public release on mobile platforms. |

---

## Getting Started (Contributor Setup)

### Prerequisites
1. **Unity Hub:** Download and install the latest [Unity Hub](https://unity.com/download).
2. **Unity Editor:** Install the exact matching version: **`Unity 6 (6000.6.4f1)`**.
   * *Required Modules:* **Android Build Support** (with OpenJDK and Android SDK & NDK tools) and **iOS Build Support** (for macOS environments).
3. **Git LFS:** Verify Git Large File Storage is active before cloning:
   ```bash
   git lfs install
