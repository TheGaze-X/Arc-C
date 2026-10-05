using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200336E RID: 13166
	[Token(Token = "0x200336E")]
	public class UIAnimationText : UIPopup
	{
		// Token: 0x06015018 RID: 86040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015018")]
		[Address(RVA = "0xD6BE50", Offset = "0xD6AA50", VA = "0x180D6BE50")]
		public void Init(string message, Transform spawnPoint)
		{
		}

		// Token: 0x06015019 RID: 86041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015019")]
		[Address(RVA = "0xD6BD90", Offset = "0xD6A990", VA = "0x180D6BD90", Slot = "8")]
		protected override void InitPosition(Transform spawnPoint, Vector2 offset)
		{
		}

		// Token: 0x0601501A RID: 86042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601501A")]
		[Address(RVA = "0xD6BF90", Offset = "0xD6AB90", VA = "0x180D6BF90", Slot = "9")]
		protected override void SetTweens(float duration)
		{
		}

		// Token: 0x0601501B RID: 86043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601501B")]
		[Address(RVA = "0xD6C070", Offset = "0xD6AC70", VA = "0x180D6C070")]
		public UIAnimationText()
		{
		}

		// Token: 0x0601501C RID: 86044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601501C")]
		[Address(RVA = "0xD6C060", Offset = "0xD6AC60", VA = "0x180D6C060")]
		private void <>xLuaBaseProxy_InitPosition(Transform P0, Vector2 P1)
		{
		}

		// Token: 0x04018FDD RID: 102365
		[Token(Token = "0x4018FDD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _popupAnim;

		// Token: 0x04018FDE RID: 102366
		[Token(Token = "0x4018FDE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _labelText;

		// Token: 0x04018FDF RID: 102367
		[Token(Token = "0x4018FDF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIFollower _follower;

		// Token: 0x04018FE0 RID: 102368
		[Token(Token = "0x4018FE0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _textFormat;

		// Token: 0x04018FE1 RID: 102369
		[Token(Token = "0x4018FE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04018FE2 RID: 102370
		[Token(Token = "0x4018FE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitPosition;

		// Token: 0x04018FE3 RID: 102371
		[Token(Token = "0x4018FE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetTweens;

		// Token: 0x04018FE4 RID: 102372
		[Token(Token = "0x4018FE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
