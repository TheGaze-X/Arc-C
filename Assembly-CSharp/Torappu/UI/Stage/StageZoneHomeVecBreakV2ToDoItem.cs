using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067F2 RID: 26610
	[Token(Token = "0x20067F2")]
	public class StageZoneHomeVecBreakV2ToDoItem : StageZoneHomeToDoItemPlugin
	{
		// Token: 0x06026236 RID: 156214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026236")]
		[Address(RVA = "0x2142620", Offset = "0x2141220", VA = "0x182142620", Slot = "6")]
		protected override Sprite LoadMainSprite()
		{
			return null;
		}

		// Token: 0x06026237 RID: 156215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026237")]
		[Address(RVA = "0x21427D0", Offset = "0x21413D0", VA = "0x1821427D0", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x06026238 RID: 156216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026238")]
		[Address(RVA = "0x21429B0", Offset = "0x21415B0", VA = "0x1821429B0")]
		public StageZoneHomeVecBreakV2ToDoItem()
		{
		}

		// Token: 0x04035B6B RID: 220011
		[Token(Token = "0x4035B6B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x04035B6C RID: 220012
		[Token(Token = "0x4035B6C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04035B6D RID: 220013
		[Token(Token = "0x4035B6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadMainSprite;

		// Token: 0x04035B6E RID: 220014
		[Token(Token = "0x4035B6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x04035B6F RID: 220015
		[Token(Token = "0x4035B6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
