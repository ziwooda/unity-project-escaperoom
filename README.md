# The-Country_Game-Project

<h3>0.DEMO</h3>
![image](https://user-images.githubusercontent.com/70079416/152958182-2b35adb5-67f7-4071-90f5-d73eb115f9ef.png)  
![image](https://user-images.githubusercontent.com/70079416/152957750-770dcd55-2e83-414a-b72c-d164c2d6f949.png)  
![image](https://user-images.githubusercontent.com/70079416/152957772-8a8f9d96-94ea-4b85-bac8-2a799460a8a6.png)  
![image](https://user-images.githubusercontent.com/70079416/152957813-da7dc5d9-505a-4389-98f9-17ee107c2374.png)  
![image](https://user-images.githubusercontent.com/70079416/152957834-c20363a3-b0fd-4c8d-9cfb-ea475a6a2269.png)  



<h3>1. 프로젝트 소개</h3>
<h4>1.1 프로젝트 제목</h4>
	 The Country; 별이 된 영웅들  

<h4>1.2 프로젝트 소개</h4>
: 이 프로젝트는 2층으로 이루어진 건물 곳곳에 숨어져 있는 아이템들을 찾아내는 게임으로, Unity3D로 개발했습니다.<br>
  이 게임은 플레이어의 1인칭 시점에서 이루어지고, 키보드와 마우스 클릭으로 플레이어가 동작, 아이템들이 선택됩니다.<br>
  플레이어가 찾아야 할 아이템들은 모두 일제강점기 시대와 연관 있는 물건들로, 물건을 찾을 때마다 그 물건이 무엇인지와<br>
  어떤 인물을 대표하는지 등의 정보와 함께 플레이어가 지금까지 찾아낸 아이템의 개수를 명시해줍니다.<br>  

  
<h3>2. 주요 기능</h3>
<h4>2.1 최종적으로 구현한 기능</h4>
 - 게임 시작 화면<br>
 - 게임 소개와 작동 방법, 찾아야 할 아이템 목록<br>
 - 아이템 목록을 확인할 수 있는 체크리스트<br>
 - 플레이어의 마우스 클릭 횟수 제한 기능<br>
 - 남은 클릭 횟수를 화면에 명시해주는 기능<br>
 - 플레이어의 움직임<br>
 		- 건물 내부를 자유롭게 이동하는 동작<br>
 		- 키보드를 이용하여 1층과 2층을 이동하는 동작<br>
 - 아이템의 간략한 정보와 플레이어가 찾은 아이템의 총 개수를 화면에 띄우는 동작<br>
 - 아이템을 전부 찾았을 시, 성공 화면을 띄우는 동작<br>
 - 마우스 클릭의 기회가 소진되면 실패 화면과 재도전 여부를 묻는 동작<br>  

<h4>2.2 구현하는 데 사용된 유니티 기능</h4>
 - 외부 에셋을 이용하여 건물 내부를 구성하고 아이템을 구현<br>
 - UI의 button 기능으로 시작 화면 및 마지막 화면, 체크리스트 등 구현<br>
 - UI의 text 기능으로 화면에 마우스 클릭 횟수 변화, 획득한 아이템과 총 개수 등 명시<br>
 - 마우스 클릭으로 아이템을 찾고, 키보드로 플레이어의 움직임 구현<br>
 - AudioSource Component를 활용하여 외부 음원 삽입<br>  

  
<h3>3. 스크립트 코드</h3>
 3.1. 시작 화면, 게임소개 화면, 게임실행 화면, 성공/실패 화면으로의 전환<br>
 		- SceneChanger.cs     
      
 3.2. 키보드의 상하 화살표로 플레이어는 앞뒤로 움직이고, 좌우 화살표로 양옆으로 회전<br>
		- PlayerMove.cs      
		
 3.3. 플레이어가 A키와 S키를 이용하여 1층과 2층을 자유롭게 이동<br>
		- FloorMove.cs      
		
 3.4. 마우스 클릭 이벤트를 수행하고, 클릭의 횟수에 제한을 둠.<br>
		- GameFunction.cs      
		
 3.5. 플레이어가 찾아서 클릭한 아이템의 정보와 찾은 아이템의 총 갯수를 출력.<br>
	 (Collider Component가 있는 물체들을 클릭하여 Ray 광선을 쏘고, 그 물체의 정보를 얻는 RayCast 방법 사용)<br>
		- ItemCollection.cs<br>
		[참조링크] https://dhy948.tistory.com/9     
		
 3.6. 게임 성공화면과 실패화면에 텍스트가 한 줄씩 뜨도록 함.<br>
		- ChatController1.cs, ChatController2.cs      
		
 3.7. 배경음악 삽입 코드. (씬이 전환되면서 배경음악이 끊기지 않도록 DontDestroyOnLoad 함수 이용)<br>
		- BGM.cs
