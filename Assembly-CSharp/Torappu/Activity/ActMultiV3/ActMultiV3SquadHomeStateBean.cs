using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FCC RID: 28620
	[Token(Token = "0x2006FCC")]
	public class ActMultiV3SquadHomeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005FF0 RID: 24560
		// (get) Token: 0x06028A58 RID: 166488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FF0")]
		public ActMultiV3SquadGroupProp prop
		{
			[Token(Token = "0x6028A58")]
			[Address(RVA = "0x23F6310", Offset = "0x23F4F10", VA = "0x1823F6310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005FF1 RID: 24561
		// (get) Token: 0x06028A59 RID: 166489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FF1")]
		public TrackPointViewProperty trackPointProp
		{
			[Token(Token = "0x6028A59")]
			[Address(RVA = "0x23F6370", Offset = "0x23F4F70", VA = "0x1823F6370")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028A5A RID: 166490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A5A")]
		[Address(RVA = "0x23F61F0", Offset = "0x23F4DF0", VA = "0x1823F61F0")]
		public ActMultiV3SquadHomeStateBean()
		{
		}

		// Token: 0x04039E96 RID: 237206
		[Token(Token = "0x4039E96")]
		[FieldOffset(Offset = "0x10")]
		private ActMultiV3SquadGroupProp m_prop;

		// Token: 0x04039E97 RID: 237207
		[Token(Token = "0x4039E97")]
		[FieldOffset(Offset = "0x18")]
		private TrackPointViewProperty m_trackPointProp;

		// Token: 0x04039E98 RID: 237208
		[Token(Token = "0x4039E98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x04039E99 RID: 237209
		[Token(Token = "0x4039E99")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_trackPointProp;

		// Token: 0x04039E9A RID: 237210
		[Token(Token = "0x4039E9A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
