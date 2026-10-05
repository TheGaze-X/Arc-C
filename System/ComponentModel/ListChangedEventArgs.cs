using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	public class ListChangedEventArgs : EventArgs
	{
		// Token: 0x06000B6A RID: 2922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x514A200", Offset = "0x5148E00", VA = "0x18514A200")]
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex)
		{
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x514A270", Offset = "0x5148E70", VA = "0x18514A270")]
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc)
		{
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x514A100", Offset = "0x5148D00", VA = "0x18514A100")]
		public ListChangedEventArgs(ListChangedType listChangedType, PropertyDescriptor propDesc)
		{
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x514A180", Offset = "0x5148D80", VA = "0x18514A180")]
		public ListChangedEventArgs(ListChangedType listChangedType, int newIndex, int oldIndex)
		{
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x1700024C")]
		public ListChangedType ListChangedType
		{
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return ListChangedType.Reset;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x1700024D")]
		public int NewIndex
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x000064C8 File Offset: 0x000046C8
		[Token(Token = "0x1700024E")]
		public int OldIndex
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024F")]
		public PropertyDescriptor PropertyDescriptor
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
