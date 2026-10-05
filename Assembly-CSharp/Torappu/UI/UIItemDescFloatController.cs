using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003736 RID: 14134
	[Token(Token = "0x2003736")]
	public class UIItemDescFloatController : PageSingleComponent
	{
		// Token: 0x06016741 RID: 91969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016741")]
		[Address(RVA = "0xEE5DE0", Offset = "0xEE49E0", VA = "0x180EE5DE0")]
		public static void ShowItemDesc(GameObject itemView, UIItemViewModel itemModel, bool enableDropRoute)
		{
		}

		// Token: 0x06016742 RID: 91970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016742")]
		[Address(RVA = "0xEE5E80", Offset = "0xEE4A80", VA = "0x180EE5E80")]
		public static void ShowItemDesc(GameObject itemView, UIItemViewModel itemModel, float itemViewScaling = 1f, bool enableDropRoute = true, bool enableVoucherRoute = false)
		{
		}

		// Token: 0x06016743 RID: 91971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016743")]
		[Address(RVA = "0xEE5A70", Offset = "0xEE4670", VA = "0x180EE5A70")]
		public static void CloseAll(UIPage page)
		{
		}

		// Token: 0x06016744 RID: 91972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016744")]
		[Address(RVA = "0xEE5FB0", Offset = "0xEE4BB0", VA = "0x180EE5FB0")]
		private static void _ShowItemDescImpl(GameObject itemView, UIItemViewModel itemModel, float itemViewScaling, bool enableDropRoute, bool enableVoucherRoute)
		{
		}

		// Token: 0x06016745 RID: 91973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016745")]
		[Address(RVA = "0xEE5BC0", Offset = "0xEE47C0", VA = "0x180EE5BC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06016746 RID: 91974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016746")]
		[Address(RVA = "0xEE5F40", Offset = "0xEE4B40", VA = "0x180EE5F40")]
		private void _OnCloseDescPanel(UIItemDescFloat.ClosePanelRequest unused)
		{
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x06016747 RID: 91975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035D7")]
		protected UIItemDescFloat floatPrefab
		{
			[Token(Token = "0x6016747")]
			[Address(RVA = "0xEE64F0", Offset = "0xEE50F0", VA = "0x180EE64F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016748 RID: 91976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016748")]
		[Address(RVA = "0xEE6290", Offset = "0xEE4E90", VA = "0x180EE6290")]
		private void _ShowItemDesc(GameObject itemView, UIItemViewModel itemModel, float itemViewScaling, bool enableDropRoute, bool enableVoucherRoute)
		{
		}

		// Token: 0x06016749 RID: 91977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016749")]
		[Address(RVA = "0xEE63B0", Offset = "0xEE4FB0", VA = "0x180EE63B0")]
		private void _TryCloseItemDesc()
		{
		}

		// Token: 0x0601674A RID: 91978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601674A")]
		[Address(RVA = "0xEE6440", Offset = "0xEE5040", VA = "0x180EE6440")]
		public UIItemDescFloatController()
		{
		}

		// Token: 0x0601674B RID: 91979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601674B")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0401B07A RID: 110714
		[Token(Token = "0x401B07A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Set this to None to enable default prefab in UIAssetLoader")]
		private UIItemDescFloat _floatPrefab;

		// Token: 0x0401B07B RID: 110715
		[Token(Token = "0x401B07B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _descBound;

		// Token: 0x0401B07C RID: 110716
		[Token(Token = "0x401B07C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("This should be full-screen to make float cover everything")]
		private RectTransform _floatHolder;

		// Token: 0x0401B07D RID: 110717
		[Token(Token = "0x401B07D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401B07E RID: 110718
		[Token(Token = "0x401B07E")]
		[FieldOffset(Offset = "0x40")]
		private UIItemDescFloat m_floatInst;

		// Token: 0x0401B07F RID: 110719
		[Token(Token = "0x401B07F")]
		[FieldOffset(Offset = "0x48")]
		private UIItemDescViewModel m_viewModel;

		// Token: 0x0401B080 RID: 110720
		[Token(Token = "0x401B080")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowItemDesc;

		// Token: 0x0401B081 RID: 110721
		[Token(Token = "0x401B081")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_ShowItemDesc;

		// Token: 0x0401B082 RID: 110722
		[Token(Token = "0x401B082")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CloseAll;

		// Token: 0x0401B083 RID: 110723
		[Token(Token = "0x401B083")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowItemDescImpl;

		// Token: 0x0401B084 RID: 110724
		[Token(Token = "0x401B084")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0401B085 RID: 110725
		[Token(Token = "0x401B085")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCloseDescPanel;

		// Token: 0x0401B086 RID: 110726
		[Token(Token = "0x401B086")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_floatPrefab;

		// Token: 0x0401B087 RID: 110727
		[Token(Token = "0x401B087")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowItemDesc;

		// Token: 0x0401B088 RID: 110728
		[Token(Token = "0x401B088")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryCloseItemDesc;

		// Token: 0x0401B089 RID: 110729
		[Token(Token = "0x401B089")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
