# C# 튜토리얼

## 목차
### C# 객체지향 문법
- [클래스](#)
- [생성자](./OOP/01.Constructor)
- [소멸자](./OOP/02.Destructor)

## 개발 환경 구성
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet)
- [Visual Studio Code](https://code.visualstudio.com/download)
- Visual Studio Code 확장 도구
  - 프로그래밍 언어
    - [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
  - 단위 테스트
    - [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
    - [Coverage Gutters](https://marketplace.visualstudio.com/items?itemName=ryanluker.vscode-coverage-gutters)
  - VSCode 탐색기
    - [vscode-solution-explorer](https://marketplace.visualstudio.com/items?itemName=fernandoescolar.vscode-solution-explorer)
    - [Peek Hidden Files](https://marketplace.visualstudio.com/items?itemName=adrianwilczynski.toggle-hidden)
    - [vscode-icons](https://marketplace.visualstudio.com/items?itemName=vscode-icons-team.vscode-icons)
  - VSCode 편집기
    - [Bookmarks](https://marketplace.visualstudio.com/items?itemName=alefragnani.Bookmarks)
    - [Trailing Spaces](https://marketplace.visualstudio.com/items?itemName=shardulm94.trailing-spaces)
  - Git
    - [gitignore](https://marketplace.visualstudio.com/items?itemName=codezombiech.gitignore)

## 개발 환경 이해
- `Console.ReadLine() 디버깅`
  - `launch.json` 변경 전
    ```json
    "console": "internalConsole",
    ```
  - `launch.json` 변경 후
    ```json
    "console": "integratedTerminal",
    ```
    
## 참고 자료
- [Visual Studio Code를 사용하여 .NET 콘솔 애플리케이션 디버그](https://docs.microsoft.com/ko-kr/dotnet/core/tutorials/debugging-with-visual-studio-code?pivots=dotnet-6-0)
