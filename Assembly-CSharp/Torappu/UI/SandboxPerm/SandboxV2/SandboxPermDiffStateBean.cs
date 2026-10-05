using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004019 RID: 16409
	[Token(Token = "0x2004019")]
	public class SandboxPermDiffStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x0601968B RID: 104075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601968B")]
		[Address(RVA = "0x1215660", Offset = "0x1214260", VA = "0x181215660")]
		public string GetModelName(int mode)
		{
			return null;
		}

		// Token: 0x0601968C RID: 104076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601968C")]
		[Address(RVA = "0x12157B0", Offset = "0x12143B0", VA = "0x1812157B0")]
		public void InitData(string i_topicId)
		{
		}

		// Token: 0x0601968D RID: 104077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601968D")]
		[Address(RVA = "0x1215D30", Offset = "0x1214930", VA = "0x181215D30")]
		public SandboxPermDiffStateBean()
		{
		}

		// Token: 0x0401F9CA RID: 129482
		[Token(Token = "0x401F9CA")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public SandboxPermDiffGroupProperty property;

		// Token: 0x0401F9CB RID: 129483
		[Token(Token = "0x401F9CB")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public string topicId;

		// Token: 0x0401F9CC RID: 129484
		[Token(Token = "0x401F9CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetModelName;

		// Token: 0x0401F9CD RID: 129485
		[Token(Token = "0x401F9CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401F9CE RID: 129486
		[Token(Token = "0x401F9CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
