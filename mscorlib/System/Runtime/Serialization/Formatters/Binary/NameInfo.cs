using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000450 RID: 1104
	[Token(Token = "0x2000450")]
	internal sealed class NameInfo
	{
		// Token: 0x060021ED RID: 8685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021ED")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		internal NameInfo()
		{
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021EE")]
		[Address(RVA = "0x4BB8740", Offset = "0x4BB7340", VA = "0x184BB8740")]
		internal void Init()
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x00013A40 File Offset: 0x00011C40
		[Token(Token = "0x17000465")]
		public bool IsSealed
		{
			[Token(Token = "0x60021EF")]
			[Address(RVA = "0x4BB87A0", Offset = "0x4BB73A0", VA = "0x184BB87A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060021F1 RID: 8689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000466")]
		public string NIname
		{
			[Token(Token = "0x60021F0")]
			[Address(RVA = "0x4BB87E0", Offset = "0x4BB73E0", VA = "0x184BB87E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60021F1")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x040012E9 RID: 4841
		[Token(Token = "0x40012E9")]
		[FieldOffset(Offset = "0x10")]
		internal string NIFullName;

		// Token: 0x040012EA RID: 4842
		[Token(Token = "0x40012EA")]
		[FieldOffset(Offset = "0x18")]
		internal long NIobjectId;

		// Token: 0x040012EB RID: 4843
		[Token(Token = "0x40012EB")]
		[FieldOffset(Offset = "0x20")]
		internal long NIassemId;

		// Token: 0x040012EC RID: 4844
		[Token(Token = "0x40012EC")]
		[FieldOffset(Offset = "0x28")]
		internal InternalPrimitiveTypeE NIprimitiveTypeEnum;

		// Token: 0x040012ED RID: 4845
		[Token(Token = "0x40012ED")]
		[FieldOffset(Offset = "0x30")]
		internal System.Type NItype;

		// Token: 0x040012EE RID: 4846
		[Token(Token = "0x40012EE")]
		[FieldOffset(Offset = "0x38")]
		internal bool NIisSealed;

		// Token: 0x040012EF RID: 4847
		[Token(Token = "0x40012EF")]
		[FieldOffset(Offset = "0x39")]
		internal bool NIisArray;

		// Token: 0x040012F0 RID: 4848
		[Token(Token = "0x40012F0")]
		[FieldOffset(Offset = "0x3A")]
		internal bool NIisArrayItem;

		// Token: 0x040012F1 RID: 4849
		[Token(Token = "0x40012F1")]
		[FieldOffset(Offset = "0x3B")]
		internal bool NItransmitTypeOnObject;

		// Token: 0x040012F2 RID: 4850
		[Token(Token = "0x40012F2")]
		[FieldOffset(Offset = "0x3C")]
		internal bool NItransmitTypeOnMember;

		// Token: 0x040012F3 RID: 4851
		[Token(Token = "0x40012F3")]
		[FieldOffset(Offset = "0x3D")]
		internal bool NIisParentTypeOnObject;

		// Token: 0x040012F4 RID: 4852
		[Token(Token = "0x40012F4")]
		[FieldOffset(Offset = "0x40")]
		internal InternalArrayTypeE NIarrayEnum;

		// Token: 0x040012F5 RID: 4853
		[Token(Token = "0x40012F5")]
		[FieldOffset(Offset = "0x44")]
		private bool NIsealedStatusChecked;
	}
}
