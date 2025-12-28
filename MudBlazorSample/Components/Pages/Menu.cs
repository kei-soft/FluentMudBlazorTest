namespace MudBlazorSample.Components.Pages
{
    /// <summary>
    /// 메뉴 트리 구조를 표현하는 클래스
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// 메뉴의 고유 ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 부모 메뉴의 ID
        /// 최상위 메뉴인 경우 null
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 메뉴에 표시될 이름
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 메뉴가 펼쳐진 상태인지 여부
        /// (MudBlazor TreeView, ExpansionPanel 등에서 사용)
        /// </summary>
        public bool IsExpanded { get; set; } = true;

        /// <summary>
        /// 하위 메뉴 목록
        /// 재귀 구조로 메뉴 트리를 구성
        /// </summary>
        public List<Menu> Children { get; set; } = new();
    }

    /// <summary>
    /// 여러 메뉴를 하나의 그룹으로 관리하기 위한 클래스
    /// (권한, 역할, 카테고리 묶음 등에 활용 가능)
    /// </summary>
    public class MenuGroup
    {
        /// <summary>
        /// 메뉴 그룹의 고유 ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 메뉴 그룹 이름
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 이 그룹에 포함된 메뉴 ID 집합
        /// HashSet을 사용해 중복 방지
        /// </summary>
        public HashSet<int> MenuIds { get; set; } = new();
    }
}
