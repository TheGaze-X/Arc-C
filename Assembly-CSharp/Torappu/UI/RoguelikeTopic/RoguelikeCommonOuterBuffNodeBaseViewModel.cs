using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004524 RID: 17700
	[Token(Token = "0x2004524")]
	public abstract class RoguelikeCommonOuterBuffNodeBaseViewModel : IHotfixable
	{
		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x0601AFC6 RID: 110534
		[Token(Token = "0x1700400A")]
		public abstract string topicId { [Token(Token = "0x601AFC6")] get; }

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x0601AFC7 RID: 110535
		[Token(Token = "0x1700400B")]
		public abstract string buffId { [Token(Token = "0x601AFC7")] get; }

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x0601AFC8 RID: 110536
		[Token(Token = "0x1700400C")]
		public abstract string buffName { [Token(Token = "0x601AFC8")] get; }

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x0601AFC9 RID: 110537
		[Token(Token = "0x1700400D")]
		public abstract string activeIconId { [Token(Token = "0x601AFC9")] get; }

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x0601AFCA RID: 110538
		[Token(Token = "0x1700400E")]
		public abstract string inactiveIconId { [Token(Token = "0x601AFCA")] get; }

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x0601AFCB RID: 110539
		[Token(Token = "0x1700400F")]
		public abstract string bottomIconId { [Token(Token = "0x601AFCB")] get; }

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x0601AFCC RID: 110540
		[Token(Token = "0x17004010")]
		public abstract string groupId { [Token(Token = "0x601AFCC")] get; }

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x0601AFCD RID: 110541
		[Token(Token = "0x17004011")]
		public abstract bool isActive { [Token(Token = "0x601AFCD")] get; }

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x0601AFCE RID: 110542
		[Token(Token = "0x17004012")]
		public abstract RoguelikeCommonOuterBuffViewType viewType { [Token(Token = "0x601AFCE")] get; }

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x0601AFCF RID: 110543
		[Token(Token = "0x17004013")]
		public abstract RoguelikeCommonDevelopmentNodeType nodeType { [Token(Token = "0x601AFCF")] get; }

		// Token: 0x0601AFD0 RID: 110544
		[Token(Token = "0x601AFD0")]
		public abstract void LoadData(string topicId, RoguelikeCommonDevelopment buffData, Dictionary<string, RoguelikeCommonDevDifficultyNodeInfo> diffData);

		// Token: 0x0601AFD1 RID: 110545
		[Token(Token = "0x601AFD1")]
		public abstract void RefreshStatus(Dictionary<string, int> playerNodeStatus);

		// Token: 0x0601AFD2 RID: 110546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFD2")]
		[Address(RVA = "0x141DB40", Offset = "0x141C740", VA = "0x18141DB40")]
		protected RoguelikeCommonOuterBuffNodeBaseViewModel()
		{
		}

		// Token: 0x04022A90 RID: 141968
		[Token(Token = "0x4022A90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
