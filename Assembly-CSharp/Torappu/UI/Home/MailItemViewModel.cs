using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Home
{
	// Token: 0x02004BB0 RID: 19376
	[Token(Token = "0x2004BB0")]
	public class MailItemViewModel
	{
		// Token: 0x1700448E RID: 17550
		// (get) Token: 0x0601D211 RID: 119313 RVA: 0x000AA9D0 File Offset: 0x000A8BD0
		[Token(Token = "0x1700448E")]
		public bool isSpecialMail
		{
			[Token(Token = "0x601D211")]
			[Address(RVA = "0x16AB4E0", Offset = "0x16AA0E0", VA = "0x1816AB4E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D212 RID: 119314 RVA: 0x000AA9E8 File Offset: 0x000A8BE8
		[Token(Token = "0x601D212")]
		[Address(RVA = "0x16AAD60", Offset = "0x16A9960", VA = "0x1816AAD60")]
		public HomeMailIndex GetIndexId()
		{
			return default(HomeMailIndex);
		}

		// Token: 0x0601D213 RID: 119315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D213")]
		[Address(RVA = "0x16AAE50", Offset = "0x16A9A50", VA = "0x1816AAE50")]
		public void LoadSurveyViewModel(ListMailBoxResponse.SurveyItem surveyItem)
		{
		}

		// Token: 0x0601D214 RID: 119316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D214")]
		[Address(RVA = "0x16AB080", Offset = "0x16A9C80", VA = "0x1816AB080")]
		public void LoadViewModel(ListMailBoxResponse.MailItem serviceModel, bool hasItem)
		{
		}

		// Token: 0x0601D215 RID: 119317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D215")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MailItemViewModel()
		{
		}

		// Token: 0x04026396 RID: 156566
		[Token(Token = "0x4026396")]
		[FieldOffset(Offset = "0x10")]
		public long mailId;

		// Token: 0x04026397 RID: 156567
		[Token(Token = "0x4026397")]
		[FieldOffset(Offset = "0x18")]
		public List<UIItemViewModel> gains;

		// Token: 0x04026398 RID: 156568
		[Token(Token = "0x4026398")]
		[FieldOffset(Offset = "0x20")]
		public string fromName;

		// Token: 0x04026399 RID: 156569
		[Token(Token = "0x4026399")]
		[FieldOffset(Offset = "0x28")]
		public Sprite avatarSprite;

		// Token: 0x0402639A RID: 156570
		[Token(Token = "0x402639A")]
		[FieldOffset(Offset = "0x30")]
		public DateTime createTime;

		// Token: 0x0402639B RID: 156571
		[Token(Token = "0x402639B")]
		[FieldOffset(Offset = "0x38")]
		public DateTime receiveTime;

		// Token: 0x0402639C RID: 156572
		[Token(Token = "0x402639C")]
		[FieldOffset(Offset = "0x40")]
		public DateTime expireTime;

		// Token: 0x0402639D RID: 156573
		[Token(Token = "0x402639D")]
		[FieldOffset(Offset = "0x48")]
		public string mailTitle;

		// Token: 0x0402639E RID: 156574
		[Token(Token = "0x402639E")]
		[FieldOffset(Offset = "0x50")]
		public string content;

		// Token: 0x0402639F RID: 156575
		[Token(Token = "0x402639F")]
		[FieldOffset(Offset = "0x58")]
		public bool isReceived;

		// Token: 0x040263A0 RID: 156576
		[Token(Token = "0x40263A0")]
		[FieldOffset(Offset = "0x5C")]
		public MailFromInfo type;

		// Token: 0x040263A1 RID: 156577
		[Token(Token = "0x40263A1")]
		[FieldOffset(Offset = "0x60")]
		public ListMailBoxResponse.MailStyle style;

		// Token: 0x040263A2 RID: 156578
		[Token(Token = "0x40263A2")]
		[FieldOffset(Offset = "0x68")]
		public MailItemViewModel.IPlugin plugin;

		// Token: 0x040263A3 RID: 156579
		[Token(Token = "0x40263A3")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isSpecialMail;

		// Token: 0x02004BB1 RID: 19377
		[Token(Token = "0x2004BB1")]
		public class IPlugin
		{
			// Token: 0x0601D216 RID: 119318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D216")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IPlugin()
			{
			}
		}
	}
}
