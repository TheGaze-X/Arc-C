using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001CF RID: 463
	[Token(Token = "0x20001CF")]
	public class NestedContainer : Container, INestedContainer, IContainer, IDisposable
	{
		// Token: 0x06000C1D RID: 3101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x5151F70", Offset = "0x5150B70", VA = "0x185151F70")]
		public NestedContainer(IComponent owner)
		{
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000278")]
		public IComponent Owner
		{
			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000279")]
		protected virtual string OwnerName
		{
			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x5152090", Offset = "0x5150C90", VA = "0x185152090", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x5151CE0", Offset = "0x51508E0", VA = "0x185151CE0", Slot = "11")]
		protected override ISite CreateSite(IComponent component, string name)
		{
			return null;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x5151DE0", Offset = "0x51509E0", VA = "0x185151DE0", Slot = "12")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x5151EB0", Offset = "0x5150AB0", VA = "0x185151EB0", Slot = "13")]
		protected override object GetService(Type service)
		{
			return null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x5151F60", Offset = "0x5150B60", VA = "0x185151F60")]
		private void OnOwnerDisposed(object sender, EventArgs e)
		{
		}

		// Token: 0x020001D0 RID: 464
		[Token(Token = "0x20001D0")]
		private class Site : INestedSite, ISite, IServiceProvider
		{
			// Token: 0x06000C24 RID: 3108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x51559A0", Offset = "0x51545A0", VA = "0x1851559A0")]
			internal Site(IComponent component, NestedContainer container, string name)
			{
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027A")]
			public IComponent Component
			{
				[Token(Token = "0x6000C25")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700027B RID: 635
			// (get) Token: 0x06000C26 RID: 3110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027B")]
			public IContainer Container
			{
				[Token(Token = "0x6000C26")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C27 RID: 3111 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x51557E0", Offset = "0x51543E0", VA = "0x1851557E0", Slot = "10")]
			public object GetService(Type service)
			{
				return null;
			}

			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000C28 RID: 3112 RVA: 0x00006D20 File Offset: 0x00004F20
			[Token(Token = "0x1700027C")]
			public bool DesignMode
			{
				[Token(Token = "0x6000C28")]
				[Address(RVA = "0x5155A10", Offset = "0x5154610", VA = "0x185155A10", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700027D")]
			public string FullName
			{
				[Token(Token = "0x6000C29")]
				[Address(RVA = "0x5155BA0", Offset = "0x51547A0", VA = "0x185155BA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000C2A RID: 3114 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000C2B RID: 3115 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700027E")]
			public string Name
			{
				[Token(Token = "0x6000C2A")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000C2B")]
				[Address(RVA = "0x5155D60", Offset = "0x5154960", VA = "0x185155D60", Slot = "9")]
				set
				{
				}
			}

			// Token: 0x04000722 RID: 1826
			[Token(Token = "0x4000722")]
			[FieldOffset(Offset = "0x10")]
			private string _name;
		}
	}
}
