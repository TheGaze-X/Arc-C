using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DBD RID: 19901
	[Token(Token = "0x2004DBD")]
	public class NameCardV2CrossAppShareRemake : CrossAppShareRemakeModelApplier
	{
		// Token: 0x0601DC12 RID: 121874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC12")]
		[Address(RVA = "0x175A7B0", Offset = "0x17593B0", VA = "0x18175A7B0", Slot = "4")]
		public override void ApplyComponentModels(ICrossAppShareModelCollector modelCollector, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601DC13 RID: 121875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DC13")]
		[Address(RVA = "0x175A950", Offset = "0x1759550", VA = "0x18175A950")]
		public NameCardV2CrossAppShareRemake()
		{
		}

		// Token: 0x040275CC RID: 161228
		[Token(Token = "0x40275CC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareBackgroundContent;

		// Token: 0x040275CD RID: 161229
		[Token(Token = "0x40275CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareIllustContent;

		// Token: 0x040275CE RID: 161230
		[Token(Token = "0x40275CE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareCollectContent;

		// Token: 0x040275CF RID: 161231
		[Token(Token = "0x40275CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareAvatarContent;

		// Token: 0x040275D0 RID: 161232
		[Token(Token = "0x40275D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CrossAppShareRemakeLayoutContent _shareRemovableContent;

		// Token: 0x040275D1 RID: 161233
		[Token(Token = "0x40275D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyComponentModels;

		// Token: 0x040275D2 RID: 161234
		[Token(Token = "0x40275D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
