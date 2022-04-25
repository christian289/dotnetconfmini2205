# 개발가이드

## 의존성

- Microsoft.Extensions.Hosting
- DevExperssMvvm


## 시연순서

1. ViewModels 폴더 생성
2. MainWindowViewModel 클래스 생성
3. MainWindowViewModel에 POCOViewModel Attribute 추가, ctor 코드 스니펫으로 생성자 추가
4. AViewModel, BViewModel, CViewModel은 MainWindowViewModel.cs 코드 페이지에 만들고 ctor을 이용해 각자 생성자 생성
5. AViewModel, BViewModel, CViewModel을 MainWindowViewModel.cs 코드 페이지에서 Visual Studio **형식 이동**기능으로 클래스명과 동일하게 코드 파일 생성
6. Views 폴더 생성
6. AView, BView, CView를 Views 폴더 안에 UserControl로 생성
7. MainWindow.xaml을 View 폴더로 이동
8. MainWindow.xaml의 네임스페이스, local 네임스페이스를 Views로 수정
9. MainWindow.xaml.cs의 네임스페이스 수정
10. App.xaml StartupUri Views/MainWindow.xaml로 수정
11. .NET 일반 호스트 구조 설정 (IoC 컨테이너) & ViewModel, View 타입 등록 (ViewModel은 POCOViewModel로 등록할 것)
12. ViewModels/ViewModelLocator.cs 구성
13. App.xaml에 ViewModelLocator Static Resource 등록
14. 각 뷰 파일에 ViewModelLocator를 이용한 DataContext 등록
15. 빌드
16. dxmvvm Mesenger 테스트 가능한 UI 구성
17. MessengerType 폴더 및 필요한 메세지 타입 생성
18. 각 ViewModel 정의