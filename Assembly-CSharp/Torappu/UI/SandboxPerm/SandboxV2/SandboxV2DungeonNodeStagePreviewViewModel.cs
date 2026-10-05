using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042B3 RID: 17075
	[Token(Token = "0x20042B3")]
	public class SandboxV2DungeonNodeStagePreviewViewModel : IHotfixable
	{
		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x0601A47D RID: 107645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E5B")]
		public string topicId
		{
			[Token(Token = "0x601A47D")]
			[Address(RVA = "0x13354E0", Offset = "0x13340E0", VA = "0x1813354E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x0601A47E RID: 107646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003E5C")]
		public string stageId
		{
			[Token(Token = "0x601A47E")]
			[Address(RVA = "0x1335480", Offset = "0x1334080", VA = "0x181335480")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A47F RID: 107647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A47F")]
		[Address(RVA = "0x1335380", Offset = "0x1333F80", VA = "0x181335380")]
		public void LoadData(string topicId, string stageId)
		{
		}

		// Token: 0x0601A480 RID: 107648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A480")]
		[Address(RVA = "0x1335420", Offset = "0x1334020", VA = "0x181335420")]
		public SandboxV2DungeonNodeStagePreviewViewModel()
		{
		}

		// Token: 0x040214D3 RID: 136403
		[Token(Token = "0x40214D3")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x040214D4 RID: 136404
		[Token(Token = "0x40214D4")]
		[FieldOffset(Offset = "0x18")]
		private string m_stageId;

		// Token: 0x040214D5 RID: 136405
		[Token(Token = "0x40214D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x040214D6 RID: 136406
		[Token(Token = "0x40214D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x040214D7 RID: 136407
		[Token(Token = "0x40214D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040214D8 RID: 136408
		[Token(Token = "0x40214D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
