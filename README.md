# 🚀 Space Travel

<img src="Assets/logo.png" width="160" align="right" alt="Space Travel logo">

화면을 탭해 외계인을 띄우고, 다가오는 장애물 사이를 통과하는 **안드로이드용 2D 캐주얼 게임**입니다.
고등학교 때 Unity를 처음 배우며 기획부터 그래픽 리소스, 사운드, Android 빌드까지 혼자 완성한 프로젝트입니다.

> 작업 시기: 2022년 7월 (고등학교 재학 중) · Unity 2021.3.11f1 · C#

## 🎮 게임 방법

- **화면 터치** → 외계인이 위로 점프
- 장애물(파이프) 사이를 통과할 때마다 **+1점**
- 장애물이나 바닥에 부딪히면 게임 오버 → 현재 점수 / 최고 점수 표시 → **Replay**

## ✨ 구현 내용

| 스크립트 | 역할 |
|---|---|
| [`alienjump.cs`](Assets/alienjump.cs) | 터치 입력 시 `Rigidbody2D` 속도로 점프 + 효과음, 충돌 시 최고 점수 갱신 후 게임 오버 씬 전환 |
| [`makepipe.cs`](Assets/makepipe.cs) | 일정 간격(`timeDiff`)마다 장애물 프리팹을 **랜덤 높이**로 생성하고 5초 후 제거 |
| [`move.cs`](Assets/move.cs) | 장애물/배경을 왼쪽으로 스크롤 |
| [`scoreup.cs`](Assets/scoreup.cs) | 장애물 사이 트리거 통과 시 점수 증가 |
| [`score.cs`](Assets/score.cs) | `static` 변수로 현재 점수·최고 점수를 씬 간에 유지 |
| [`CurrentScore.cs`](Assets/CurrentScore.cs) / [`BestScore.cs`](Assets/BestScore.cs) | 게임 오버 화면 점수 표시 |
| [`Replay.cs`](Assets/Replay.cs) | 버튼 클릭 시 플레이 씬 재시작 |

- 2D 물리(`Rigidbody2D`, `Collider2D`, Trigger)와 씬 전환(`SceneManager`) 활용
- 외계인 날갯짓 / 바닥 스크롤 **애니메이션**(Animator Controller) 직접 제작
- Android 빌드(APK / AAB) 및 앱 아이콘 설정

## 📦 다운로드

[Releases](../../releases)에서 APK를 받아 Android 기기에 설치할 수 있습니다.

## ▶️ 프로젝트 열기

1. Unity Hub에서 **Unity 2021.3.11f1**(또는 2021.3 LTS) 설치
2. `Open` → 이 폴더 선택
3. `Assets/Scenes/PlayScene`을 열고 ▶ Play (`GameOverScene`은 게임 오버 화면)
