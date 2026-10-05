using System;
using Il2CppDummyDll;

namespace Torappu.Activity
{
	// Token: 0x02006D4A RID: 27978
	[Token(Token = "0x2006D4A")]
	public class DefaultActAnimContext : IActAnimContext
	{
		// Token: 0x06027E0F RID: 163343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E0F")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public DefaultActAnimContext(string activityId)
		{
		}

		// Token: 0x06027E10 RID: 163344 RVA: 0x000CFC00 File Offset: 0x000CDE00
		[Token(Token = "0x6027E10")]
		[Address(RVA = "0x22F8AA0", Offset = "0x22F76A0", VA = "0x1822F8AA0", Slot = "6")]
		public virtual bool CanSkipAnim()
		{
			return default(bool);
		}

		// Token: 0x06027E11 RID: 163345 RVA: 0x000CFC18 File Offset: 0x000CDE18
		[Token(Token = "0x6027E11")]
		[Address(RVA = "0x22F8AA0", Offset = "0x22F76A0", VA = "0x1822F8AA0")]
		protected bool _IsActStageClosed()
		{
			return default(bool);
		}

		// Token: 0x17005E57 RID: 24151
		// (get) Token: 0x06027E12 RID: 163346 RVA: 0x000CFC30 File Offset: 0x000CDE30
		[Token(Token = "0x17005E57")]
		public virtual float animDuration
		{
			[Token(Token = "0x6027E12")]
			[Address(RVA = "0x2251AE0", Offset = "0x22506E0", VA = "0x182251AE0", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x04038873 RID: 231539
		[Token(Token = "0x4038873")]
		[FieldOffset(Offset = "0x10")]
		private string m_actId;
	}
}
