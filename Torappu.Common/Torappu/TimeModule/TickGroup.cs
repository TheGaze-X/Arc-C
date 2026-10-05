using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.TimeModule
{
	// Token: 0x02000135 RID: 309
	[Token(Token = "0x2000135")]
	public class TickGroup
	{
		// Token: 0x06000759 RID: 1881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x55282B0", Offset = "0x5526EB0", VA = "0x1855282B0")]
		private TickFunction _AddTickFunction(ITickOwner owner, Action<float> func, string name)
		{
			return null;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x5528570", Offset = "0x5527170", VA = "0x185528570")]
		private void _Release()
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x55287E0", Offset = "0x55273E0", VA = "0x1855287E0")]
		private void _Tick(float unscaledDeltaTime, double unscaledTime)
		{
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x5528370", Offset = "0x5526F70", VA = "0x185528370")]
		private void _ChangeGlobalTimeScale(float timeScale)
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x5528A20", Offset = "0x5527620", VA = "0x185528A20")]
		public TickGroup()
		{
		}

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0x10")]
		protected List<TickFunction> m_tickFuncs;

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x18")]
		protected List<TickFunction> m_tickBuffer;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x20")]
		protected readonly List<TickFunction> m_pendingAddFuncs;

		// Token: 0x02000136 RID: 310
		[Token(Token = "0x2000136")]
		public struct RootOptions
		{
			// Token: 0x0400065B RID: 1627
			[Token(Token = "0x400065B")]
			[FieldOffset(Offset = "0x0")]
			public int frameRate;
		}

		// Token: 0x02000137 RID: 311
		[Token(Token = "0x2000137")]
		public class Root
		{
			// Token: 0x1700009E RID: 158
			// (get) Token: 0x0600075E RID: 1886 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x0600075F RID: 1887 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x1700009E")]
			public string name
			{
				[Token(Token = "0x600075E")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600075F")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000760 RID: 1888 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x55262A0", Offset = "0x5524EA0", VA = "0x1855262A0")]
			public Root(string pName)
			{
			}

			// Token: 0x06000761 RID: 1889 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x5526210", Offset = "0x5524E10", VA = "0x185526210")]
			public void SetOptions(TickGroup.RootOptions options)
			{
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x55261F0", Offset = "0x5524DF0", VA = "0x1855261F0")]
			public void SetGlobalTimeScale(float timeScale)
			{
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x5526240", Offset = "0x5524E40", VA = "0x185526240")]
			public void Tick(float unscaledDeltaTime, double unscaledTime)
			{
			}

			// Token: 0x06000764 RID: 1892 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x55260E0", Offset = "0x5524CE0", VA = "0x1855260E0")]
			public TickFunction AddTickFunction(ITickOwner owner, Action<float> func, string name)
			{
				return null;
			}

			// Token: 0x06000765 RID: 1893 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x55261B0", Offset = "0x5524DB0", VA = "0x1855261B0")]
			public void Release()
			{
			}

			// Token: 0x0400065C RID: 1628
			[Token(Token = "0x400065C")]
			[FieldOffset(Offset = "0x10")]
			private TickGroup m_group;

			// Token: 0x0400065E RID: 1630
			[Token(Token = "0x400065E")]
			[FieldOffset(Offset = "0x20")]
			private float m_frameInterval;

			// Token: 0x0400065F RID: 1631
			[Token(Token = "0x400065F")]
			[FieldOffset(Offset = "0x28")]
			private double m_lastTickTs;
		}
	}
}
