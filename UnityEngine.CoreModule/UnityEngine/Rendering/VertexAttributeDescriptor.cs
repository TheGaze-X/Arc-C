using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000254 RID: 596
	[Token(Token = "0x2000254")]
	[UsedByNativeCode]
	public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000D77 RID: 3447 RVA: 0x00006D38 File Offset: 0x00004F38
		// (set) Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AB")]
		public VertexAttribute attribute
		{
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return VertexAttribute.Position;
			}
			[Token(Token = "0x6000D78")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000D79 RID: 3449 RVA: 0x00006D50 File Offset: 0x00004F50
		// (set) Token: 0x06000D7A RID: 3450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AC")]
		public VertexAttributeFormat format
		{
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			[CompilerGenerated]
			readonly get
			{
				return VertexAttributeFormat.Float32;
			}
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00006D68 File Offset: 0x00004F68
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AD")]
		public int dimension
		{
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00006D80 File Offset: 0x00004F80
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		public int stream
		{
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x375DB10", Offset = "0x375C710", VA = "0x18375DB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x1CA1750", Offset = "0x1CA0350", VA = "0x181CA1750")]
		public VertexAttributeDescriptor(VertexAttribute attribute = VertexAttribute.Position, VertexAttributeFormat format = VertexAttributeFormat.Float32, int dimension = 3, int stream = 0)
		{
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x5978ED0", Offset = "0x5977AD0", VA = "0x185978ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x5978EB0", Offset = "0x5977AB0", VA = "0x185978EB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x5978DF0", Offset = "0x59779F0", VA = "0x185978DF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x5936EF0", Offset = "0x5935AF0", VA = "0x185936EF0", Slot = "4")]
		public bool Equals(VertexAttributeDescriptor other)
		{
			return default(bool);
		}
	}
}
