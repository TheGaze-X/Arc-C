using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DC5 RID: 19909
	[Token(Token = "0x2004DC5")]
	public class NameCardV2ShareAvatarRemakeLayoutElement : CrossAppShareRemakeBaseLayoutElement
	{
		// Token: 0x0601DC44 RID: 121924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC44")]
		[Address(RVA = "0x175ED30", Offset = "0x175D930", VA = "0x18175ED30", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DC45 RID: 121925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC45")]
		[Address(RVA = "0x175F040", Offset = "0x175DC40", VA = "0x18175F040")]
		public NameCardV2ShareAvatarRemakeLayoutElement()
		{
		}

		// Token: 0x0402763F RID: 161343
		[Token(Token = "0x402763F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _doctorLevel;

		// Token: 0x04027640 RID: 161344
		[Token(Token = "0x4027640")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _doctorName;

		// Token: 0x04027641 RID: 161345
		[Token(Token = "0x4027641")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _doctorUid;

		// Token: 0x04027642 RID: 161346
		[Token(Token = "0x4027642")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _bgImg;

		// Token: 0x04027643 RID: 161347
		[Token(Token = "0x4027643")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CrossAppShareRemakeDynAssetContent _crossAppShareAvatarContent;

		// Token: 0x04027644 RID: 161348
		[Token(Token = "0x4027644")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _uidObject;

		// Token: 0x04027645 RID: 161349
		[Token(Token = "0x4027645")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x04027646 RID: 161350
		[Token(Token = "0x4027646")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
