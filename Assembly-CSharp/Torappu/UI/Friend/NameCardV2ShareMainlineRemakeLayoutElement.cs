using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DDA RID: 19930
	[Token(Token = "0x2004DDA")]
	public class NameCardV2ShareMainlineRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DCC7 RID: 122055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCC7")]
		[Address(RVA = "0x1766200", Offset = "0x1764E00", VA = "0x181766200", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DCC8 RID: 122056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DCC8")]
		[Address(RVA = "0x1766540", Offset = "0x1765140", VA = "0x181766540")]
		public NameCardV2ShareMainlineRemakeLayoutElement()
		{
		}

		// Token: 0x04027748 RID: 161608
		[Token(Token = "0x4027748")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _bgRect;

		// Token: 0x04027749 RID: 161609
		[Token(Token = "0x4027749")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _mainlineIcon;

		// Token: 0x0402774A RID: 161610
		[Token(Token = "0x402774A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _constText;

		// Token: 0x0402774B RID: 161611
		[Token(Token = "0x402774B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _chapterEnName;

		// Token: 0x0402774C RID: 161612
		[Token(Token = "0x402774C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _stageProgress;

		// Token: 0x0402774D RID: 161613
		[Token(Token = "0x402774D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _allComplete;

		// Token: 0x0402774E RID: 161614
		[Token(Token = "0x402774E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _chapterImage;

		// Token: 0x0402774F RID: 161615
		[Token(Token = "0x402774F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x04027750 RID: 161616
		[Token(Token = "0x4027750")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
