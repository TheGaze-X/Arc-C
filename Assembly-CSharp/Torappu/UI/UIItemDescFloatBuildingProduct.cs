using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003735 RID: 14133
	[Token(Token = "0x2003735")]
	public class UIItemDescFloatBuildingProduct : MonoBehaviour, IHotfixable
	{
		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0601673B RID: 91963 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601673C RID: 91964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035D6")]
		public Action<BuildingData.RoomType, ItemBundle> onRoomClicked
		{
			[Token(Token = "0x601673B")]
			[Address(RVA = "0xEE5990", Offset = "0xEE4590", VA = "0x180EE5990")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601673C")]
			[Address(RVA = "0xEE59F0", Offset = "0xEE45F0", VA = "0x180EE59F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601673D RID: 91965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601673D")]
		[Address(RVA = "0xEE5530", Offset = "0xEE4130", VA = "0x180EE5530")]
		public void Render(BuildingData.RoomType roomType, string formulaId, bool enableDropRoute, UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x0601673E RID: 91966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601673E")]
		[Address(RVA = "0xEE54D0", Offset = "0xEE40D0", VA = "0x180EE54D0")]
		public void EventOnLockBtnClicked()
		{
		}

		// Token: 0x0601673F RID: 91967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601673F")]
		[Address(RVA = "0xEE5390", Offset = "0xEE3F90", VA = "0x180EE5390")]
		public void EventOnGotoBtnClicked()
		{
		}

		// Token: 0x06016740 RID: 91968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016740")]
		[Address(RVA = "0xEE5930", Offset = "0xEE4530", VA = "0x180EE5930")]
		public UIItemDescFloatBuildingProduct()
		{
		}

		// Token: 0x0401B069 RID: 110697
		[Token(Token = "0x401B069")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _roomName;

		// Token: 0x0401B06A RID: 110698
		[Token(Token = "0x401B06A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _gotoButton;

		// Token: 0x0401B06B RID: 110699
		[Token(Token = "0x401B06B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _lockButton;

		// Token: 0x0401B06C RID: 110700
		[Token(Token = "0x401B06C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _ableTips;

		// Token: 0x0401B06D RID: 110701
		[Token(Token = "0x401B06D")]
		[FieldOffset(Offset = "0x38")]
		private string m_lockInfoCache;

		// Token: 0x0401B06E RID: 110702
		[Token(Token = "0x401B06E")]
		[FieldOffset(Offset = "0x40")]
		private BuildingData.RoomType m_roomTypeCache;

		// Token: 0x0401B06F RID: 110703
		[Token(Token = "0x401B06F")]
		[FieldOffset(Offset = "0x44")]
		private bool m_enableDropRoute;

		// Token: 0x0401B070 RID: 110704
		[Token(Token = "0x401B070")]
		[FieldOffset(Offset = "0x45")]
		private bool m_isEnabled;

		// Token: 0x0401B071 RID: 110705
		[Token(Token = "0x401B071")]
		[FieldOffset(Offset = "0x46")]
		private bool m_hasGone;

		// Token: 0x0401B072 RID: 110706
		[Token(Token = "0x401B072")]
		[FieldOffset(Offset = "0x48")]
		private UIItemViewModel m_cacheViewModel;

		// Token: 0x0401B074 RID: 110708
		[Token(Token = "0x401B074")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onRoomClicked;

		// Token: 0x0401B075 RID: 110709
		[Token(Token = "0x401B075")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onRoomClicked;

		// Token: 0x0401B076 RID: 110710
		[Token(Token = "0x401B076")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401B077 RID: 110711
		[Token(Token = "0x401B077")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnLockBtnClicked;

		// Token: 0x0401B078 RID: 110712
		[Token(Token = "0x401B078")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnGotoBtnClicked;

		// Token: 0x0401B079 RID: 110713
		[Token(Token = "0x401B079")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
