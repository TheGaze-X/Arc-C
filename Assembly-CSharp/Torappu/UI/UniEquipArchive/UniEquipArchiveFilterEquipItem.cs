using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BCB RID: 15307
	[Token(Token = "0x2003BCB")]
	public class UniEquipArchiveFilterEquipItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x06017F6B RID: 98155 RVA: 0x00098C58 File Offset: 0x00096E58
		[Token(Token = "0x1700393C")]
		public UniEquipArchiveFilterEquipState equipState
		{
			[Token(Token = "0x6017F6B")]
			[Address(RVA = "0x1064370", Offset = "0x1062F70", VA = "0x181064370")]
			get
			{
				return UniEquipArchiveFilterEquipState.ALL;
			}
		}

		// Token: 0x06017F6C RID: 98156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F6C")]
		[Address(RVA = "0x1064280", Offset = "0x1062E80", VA = "0x181064280")]
		public void Render(bool isSelected)
		{
		}

		// Token: 0x06017F6D RID: 98157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F6D")]
		[Address(RVA = "0x1064210", Offset = "0x1062E10", VA = "0x181064210")]
		public void OnClick()
		{
		}

		// Token: 0x06017F6E RID: 98158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F6E")]
		[Address(RVA = "0x1064310", Offset = "0x1062F10", VA = "0x181064310")]
		public UniEquipArchiveFilterEquipItem()
		{
		}

		// Token: 0x0401D007 RID: 118791
		[Token(Token = "0x401D007")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UniEquipArchiveFilterEquipState _equipState;

		// Token: 0x0401D008 RID: 118792
		[Token(Token = "0x401D008")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _text;

		// Token: 0x0401D009 RID: 118793
		[Token(Token = "0x401D009")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0401D00A RID: 118794
		[Token(Token = "0x401D00A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _unselectedColor;

		// Token: 0x0401D00B RID: 118795
		[Token(Token = "0x401D00B")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<UniEquipArchiveFilterEquipState> onUnlockTabClick;

		// Token: 0x0401D00C RID: 118796
		[Token(Token = "0x401D00C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_equipState;

		// Token: 0x0401D00D RID: 118797
		[Token(Token = "0x401D00D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D00E RID: 118798
		[Token(Token = "0x401D00E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401D00F RID: 118799
		[Token(Token = "0x401D00F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
