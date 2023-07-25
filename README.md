# Bus_Stop.ex
프로젝트를 진행하면서 몰랐던 것들을 정리하기 위한 리포지토리


1. ASP.NET Core 웹앱(Model-view-Controller) 생성

2. appsettings.json 에서 연결 문자열 추가

'''
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  // 이 부분부터 추가
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;port=3306;database=bus;user=root;password=12345;"
  }
}
'''
