# 만들면서 어려웠던거



문제점: XRDirectInteractor를 사용할 때 AddListener를 이용해 코드로 OnGrab 이벤트를 등록했으나, 실제 물체를 잡았을 때 함수가 호출되지 않음.



해결 방법: OnGrab 함수를 public으로 변경하고, 유니티 인스펙터 창의 Interactable Events (Select Entered) 항목에 직접 스크립트와 함수를 연결하여 해결함.



학습 내용:



코드 상의 AddListener는 스크립트 실행 순서(Execution Order)나 컴포넌트 참조 시점에 따라 등록이 누락될 수 있음.



이벤트가 제대로 먹지 않을 때는 인스펙터에서 직접 연결하는 방식이 가장 직관적이고 확실한 해결책이 됨.



컴포넌트가 여러 개일 때는 GetComponent가 엉뚱한 오브젝트를 찾고 있지 않은지 항상 확인해야 함.

