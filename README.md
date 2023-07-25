# Bus_Stop.ex
프로젝트를 진행하면서 몰랐던 것들을 정리하기 위한 리포지토리


1. ASP.NET Core 웹앱(Model-view-Controller) 생성

2. appsettings.json 에서 연결 문자열 추가

```
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
```
3. 구현에 필요한 NUGET 패키지 설치
 - Microsoft.EntityFrameworkCore
 - Microsoft.EntityFrameworkCore.Tools
 - MySql.EntityFrameworkCore
 - Pomelo.EntityFrameworkCore.MySql

4. 테이블에 속성 생성

```
    public partial class BusTable
    {
        [Key] // 추가해야함
        public int BusIdx { get; set; }

        public string BusNum { get; set; } = null!;

        public int BusCnt { get; set; }

        public int BusGap { get; set; }

        public int BusNowIn { get; set; }
    }
```

5. 데이터베이스와 연결하기 위한 Dbcontext 파일 작성
   - Dbcontext의 역활
     -  DbContext는 데이터베이스의 테이블과 데이터를 C# 클래스와 객체로 매핑하여 애플리케이션과 데이터베이스 간의 데이터 접근을 쉽게 만듬 
```
    public partial class BusContext : DbContext // 옆에 DbContext 문자열을 추가해준다.
    {
        public BusContext() { }


        // 이 밑에 소스를 작성해야지 Add-Migration이 작동함
        public BusContext(DbContextOptions<BusContext> options)
            : base(options)
        {
        }
    }
```

3. 컨트롤러 추가
  - Controllers 폴더에서 우클릭
    - 추가를 누르면 컨트롤러가 있다
    - Entity Framework를 사용하며 동작이 포함된 API 컨트롤러 생성
    - 모델 클래스에 속성 정의해놓은 클래스 선택
    - DbContext 클래스에 DbContext 문자열 추가해놓은 클래스 선택
    - 추가 누르면 생성이 됨

4. 데이터베이스 생성
   - 패키지 관리자 콘솔에서 Add-Migration 테이블명 을 작성한다
   - 오류 메세지가 없으면 Update-Database를 작성한다
   - 실행이 완료되면 Migration 폴더가 생기고 MySQL에 들어가면 테이블이 생성이 되어있다.
   - 속성은 세부적으로 설정한 것이 아니어서 필요시 MySQL에서 수정해도 된다

