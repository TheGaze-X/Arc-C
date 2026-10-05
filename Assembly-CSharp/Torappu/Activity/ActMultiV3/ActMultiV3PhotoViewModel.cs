using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F85 RID: 28549
	[Token(Token = "0x2006F85")]
	public class ActMultiV3PhotoViewModel : IHotfixable
	{
		// Token: 0x06028846 RID: 165958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028846")]
		[Address(RVA = "0x23DBB60", Offset = "0x23DA760", VA = "0x1823DBB60")]
		public ActMultiV3PhotoViewModel(string actId, string templateId, string photoInstId, ActMultiV3PhotoTypeData photoTypeData, PlayerActivity.PlayerMultiV3Activity.Photo photo)
		{
		}

		// Token: 0x06028847 RID: 165959 RVA: 0x000D1F40 File Offset: 0x000D0140
		[Token(Token = "0x6028847")]
		[Address(RVA = "0x23DB980", Offset = "0x23DA580", VA = "0x1823DB980")]
		private bool _CheckTrackPoint(string actId, Dictionary<string, PlayerActivity.PlayerMultiV3Activity.PhotoInstance> photoCollection)
		{
			return default(bool);
		}

		// Token: 0x04039B0C RID: 236300
		[Token(Token = "0x4039B0C")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04039B0D RID: 236301
		[Token(Token = "0x4039B0D")]
		[FieldOffset(Offset = "0x18")]
		public int photoTypeIdx;

		// Token: 0x04039B0E RID: 236302
		[Token(Token = "0x4039B0E")]
		[FieldOffset(Offset = "0x20")]
		public string photoTemplateId;

		// Token: 0x04039B0F RID: 236303
		[Token(Token = "0x4039B0F")]
		[FieldOffset(Offset = "0x28")]
		public string photoInstId;

		// Token: 0x04039B10 RID: 236304
		[Token(Token = "0x4039B10")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x04039B11 RID: 236305
		[Token(Token = "0x4039B11")]
		[FieldOffset(Offset = "0x34")]
		public bool containPhoto;

		// Token: 0x04039B12 RID: 236306
		[Token(Token = "0x4039B12")]
		[FieldOffset(Offset = "0x35")]
		public bool hasTrackPoint;

		// Token: 0x04039B13 RID: 236307
		[Token(Token = "0x4039B13")]
		[FieldOffset(Offset = "0x38")]
		public string photoTypeName;

		// Token: 0x04039B14 RID: 236308
		[Token(Token = "0x4039B14")]
		[FieldOffset(Offset = "0x40")]
		public string photoBg;

		// Token: 0x04039B15 RID: 236309
		[Token(Token = "0x4039B15")]
		[FieldOffset(Offset = "0x48")]
		public List<ActMultiV3PhotoCharViewModel> charModels;

		// Token: 0x04039B16 RID: 236310
		[Token(Token = "0x4039B16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039B17 RID: 236311
		[Token(Token = "0x4039B17")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CheckTrackPoint;
	}
}
