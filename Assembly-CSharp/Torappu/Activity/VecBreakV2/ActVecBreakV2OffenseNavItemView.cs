using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E50 RID: 28240
	[Token(Token = "0x2006E50")]
	public class ActVecBreakV2OffenseNavItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028312 RID: 164626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028312")]
		[Address(RVA = "0x2377560", Offset = "0x2376160", VA = "0x182377560")]
		public void Render(VecBreakV2OffenseStageModel stageModel, Color themeColor)
		{
		}

		// Token: 0x06028313 RID: 164627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028313")]
		[Address(RVA = "0x23777C0", Offset = "0x23763C0", VA = "0x1823777C0")]
		public ActVecBreakV2OffenseNavItemView()
		{
		}

		// Token: 0x04039142 RID: 233794
		[Token(Token = "0x4039142")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _lockedPartGo;

		// Token: 0x04039143 RID: 233795
		[Token(Token = "0x4039143")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedBossPartGo;

		// Token: 0x04039144 RID: 233796
		[Token(Token = "0x4039144")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _incompleteImage;

		// Token: 0x04039145 RID: 233797
		[Token(Token = "0x4039145")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _incompleteBossImage;

		// Token: 0x04039146 RID: 233798
		[Token(Token = "0x4039146")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _completePartGo;

		// Token: 0x04039147 RID: 233799
		[Token(Token = "0x4039147")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _completeBossPartGo;

		// Token: 0x04039148 RID: 233800
		[Token(Token = "0x4039148")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039149 RID: 233801
		[Token(Token = "0x4039149")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
