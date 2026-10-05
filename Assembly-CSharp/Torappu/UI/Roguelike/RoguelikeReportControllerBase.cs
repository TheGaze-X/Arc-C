using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005375 RID: 21365
	[Token(Token = "0x2005375")]
	public abstract class RoguelikeReportControllerBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x0601F7D3 RID: 128979 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F7D4 RID: 128980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049D8")]
		public RoguelikeReportPage page
		{
			[Token(Token = "0x601F7D3")]
			[Address(RVA = "0x192EF60", Offset = "0x192DB60", VA = "0x18192EF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F7D4")]
			[Address(RVA = "0x192F020", Offset = "0x192DC20", VA = "0x18192F020")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x0601F7D5 RID: 128981 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F7D6 RID: 128982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049D9")]
		public string topicId
		{
			[Token(Token = "0x601F7D5")]
			[Address(RVA = "0x192EFC0", Offset = "0x192DBC0", VA = "0x18192EFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F7D6")]
			[Address(RVA = "0x192F0A0", Offset = "0x192DCA0", VA = "0x18192F0A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0601F7D7 RID: 128983
		[Token(Token = "0x601F7D7")]
		public abstract void Init(RoguelikeReportPage page, RoguelikeReportPage.Param param);

		// Token: 0x0601F7D8 RID: 128984
		[Token(Token = "0x601F7D8")]
		public abstract void NotifyClosePage();

		// Token: 0x0601F7D9 RID: 128985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7D9")]
		[Address(RVA = "0x192EF00", Offset = "0x192DB00", VA = "0x18192EF00")]
		protected RoguelikeReportControllerBase()
		{
		}

		// Token: 0x0402A5F3 RID: 173555
		[Token(Token = "0x402A5F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402A5F4 RID: 173556
		[Token(Token = "0x402A5F4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402A5F5 RID: 173557
		[Token(Token = "0x402A5F5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402A5F6 RID: 173558
		[Token(Token = "0x402A5F6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402A5F7 RID: 173559
		[Token(Token = "0x402A5F7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
