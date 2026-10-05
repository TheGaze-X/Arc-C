using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BDF RID: 31711
	[Token(Token = "0x2007BDF")]
	public sealed class InspectedProperty
	{
		// Token: 0x170067EC RID: 26604
		// (get) Token: 0x0602C60C RID: 181772 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602C60D RID: 181773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067EC")]
		public MemberInfo MemberInfo
		{
			[Token(Token = "0x602C60C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602C60D")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170067ED RID: 26605
		// (get) Token: 0x0602C60E RID: 181774 RVA: 0x000DFD58 File Offset: 0x000DDF58
		[Token(Token = "0x170067ED")]
		public bool IsPublic
		{
			[Token(Token = "0x602C60E")]
			[Address(RVA = "0x285CEA0", Offset = "0x285BAA0", VA = "0x18285CEA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170067EE RID: 26606
		// (get) Token: 0x0602C60F RID: 181775 RVA: 0x000DFD70 File Offset: 0x000DDF70
		[Token(Token = "0x170067EE")]
		public bool IsAutoProperty
		{
			[Token(Token = "0x602C60F")]
			[Address(RVA = "0x285CC10", Offset = "0x285B810", VA = "0x18285CC10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170067EF RID: 26607
		// (get) Token: 0x0602C610 RID: 181776 RVA: 0x000DFD88 File Offset: 0x000DDF88
		// (set) Token: 0x0602C611 RID: 181777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067EF")]
		public bool IsStatic
		{
			[Token(Token = "0x602C610")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C611")]
			[Address(RVA = "0x4EF620", Offset = "0x4EE220", VA = "0x1804EF620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170067F0 RID: 26608
		// (get) Token: 0x0602C612 RID: 181778 RVA: 0x000DFDA0 File Offset: 0x000DDFA0
		// (set) Token: 0x0602C613 RID: 181779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170067F0")]
		public bool CanWrite
		{
			[Token(Token = "0x602C612")]
			[Address(RVA = "0x106F290", Offset = "0x106DE90", VA = "0x18106F290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602C613")]
			[Address(RVA = "0x106F2A0", Offset = "0x106DEA0", VA = "0x18106F2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602C614 RID: 181780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C614")]
		[Address(RVA = "0x285C490", Offset = "0x285B090", VA = "0x18285C490")]
		public void Write(object context, object value)
		{
		}

		// Token: 0x0602C615 RID: 181781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C615")]
		[Address(RVA = "0x285BDE0", Offset = "0x285A9E0", VA = "0x18285BDE0")]
		public object Read(object context)
		{
			return null;
		}

		// Token: 0x170067F1 RID: 26609
		// (get) Token: 0x0602C616 RID: 181782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067F1")]
		public object DefaultValue
		{
			[Token(Token = "0x602C616")]
			[Address(RVA = "0x285CB50", Offset = "0x285B750", VA = "0x18285CB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C617 RID: 181783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C617")]
		[Address(RVA = "0x285CA30", Offset = "0x285B630", VA = "0x18285CA30")]
		public InspectedProperty(PropertyInfo property)
		{
		}

		// Token: 0x0602C618 RID: 181784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C618")]
		[Address(RVA = "0x285C990", Offset = "0x285B590", VA = "0x18285C990")]
		public InspectedProperty(FieldInfo field)
		{
		}

		// Token: 0x0602C619 RID: 181785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C619")]
		[Address(RVA = "0x285C370", Offset = "0x285AF70", VA = "0x18285C370")]
		private void SetupNames()
		{
		}

		// Token: 0x0602C61A RID: 181786 RVA: 0x000DFDB8 File Offset: 0x000DDFB8
		[Token(Token = "0x602C61A")]
		[Address(RVA = "0x285BBE0", Offset = "0x285A7E0", VA = "0x18285BBE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0602C61B RID: 181787 RVA: 0x000DFDD0 File Offset: 0x000DDFD0
		[Token(Token = "0x602C61B")]
		[Address(RVA = "0x285BCB0", Offset = "0x285A8B0", VA = "0x18285BCB0")]
		public bool Equals(InspectedProperty p)
		{
			return default(bool);
		}

		// Token: 0x0602C61C RID: 181788 RVA: 0x000DFDE8 File Offset: 0x000DDFE8
		[Token(Token = "0x602C61C")]
		[Address(RVA = "0x285BD50", Offset = "0x285A950", VA = "0x18285BD50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04040256 RID: 262742
		[Token(Token = "0x4040256")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04040257 RID: 262743
		[Token(Token = "0x4040257")]
		[FieldOffset(Offset = "0x20")]
		public string DisplayName;

		// Token: 0x04040258 RID: 262744
		[Token(Token = "0x4040258")]
		[FieldOffset(Offset = "0x28")]
		private bool? _isPublicCache;

		// Token: 0x04040259 RID: 262745
		[Token(Token = "0x4040259")]
		[FieldOffset(Offset = "0x2A")]
		private bool? _isAutoPropertyCache;

		// Token: 0x0404025C RID: 262748
		[Token(Token = "0x404025C")]
		[FieldOffset(Offset = "0x30")]
		public Type StorageType;
	}
}
