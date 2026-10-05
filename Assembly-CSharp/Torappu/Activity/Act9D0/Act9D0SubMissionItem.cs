using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200717D RID: 29053
	[Token(Token = "0x200717D")]
	public class Act9D0SubMissionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700619B RID: 24987
		// (get) Token: 0x060293E5 RID: 168933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700619B")]
		public string subMissionId
		{
			[Token(Token = "0x60293E5")]
			[Address(RVA = "0x24A5790", Offset = "0x24A4390", VA = "0x1824A5790")]
			get
			{
				return null;
			}
		}

		// Token: 0x060293E6 RID: 168934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293E6")]
		[Address(RVA = "0x24A5650", Offset = "0x24A4250", VA = "0x1824A5650")]
		public void Render(SubMissionViewModel viewModel)
		{
		}

		// Token: 0x060293E7 RID: 168935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293E7")]
		[Address(RVA = "0x24A5560", Offset = "0x24A4160", VA = "0x1824A5560")]
		public void OnClick()
		{
		}

		// Token: 0x060293E8 RID: 168936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293E8")]
		[Address(RVA = "0x24A5730", Offset = "0x24A4330", VA = "0x1824A5730")]
		public Act9D0SubMissionItem()
		{
		}

		// Token: 0x0403AE76 RID: 241270
		[Token(Token = "0x403AE76")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _subMissionId;

		// Token: 0x0403AE77 RID: 241271
		[Token(Token = "0x403AE77")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hasAllPart;

		// Token: 0x0403AE78 RID: 241272
		[Token(Token = "0x403AE78")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _fillAmount;

		// Token: 0x0403AE79 RID: 241273
		[Token(Token = "0x403AE79")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIStringEvent _clickEvent;

		// Token: 0x0403AE7A RID: 241274
		[Token(Token = "0x403AE7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_subMissionId;

		// Token: 0x0403AE7B RID: 241275
		[Token(Token = "0x403AE7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AE7C RID: 241276
		[Token(Token = "0x403AE7C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403AE7D RID: 241277
		[Token(Token = "0x403AE7D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
