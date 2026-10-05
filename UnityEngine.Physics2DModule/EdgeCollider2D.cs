using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[NativeHeader("Modules/Physics2D/Public/EdgeCollider2D.h")]
	public sealed class EdgeCollider2D : Collider2D
	{
		// Token: 0x0600007D RID: 125
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x59C33A0", Offset = "0x59C1FA0", VA = "0x1859C33A0")]
		[MethodImpl(4096)]
		public extern void Reset();

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007E RID: 126
		// (set) Token: 0x0600007F RID: 127
		[Token(Token = "0x1700001F")]
		public extern float edgeRadius { [Token(Token = "0x600007E")] [Address(RVA = "0x59C35B0", Offset = "0x59C21B0", VA = "0x1859C35B0")] [MethodImpl(4096)] get; [Token(Token = "0x600007F")] [Address(RVA = "0x59C3810", Offset = "0x59C2410", VA = "0x1859C3810")] [MethodImpl(4096)] set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000080 RID: 128
		[Token(Token = "0x17000020")]
		public extern int edgeCount { [Token(Token = "0x6000080")] [Address(RVA = "0x59C3570", Offset = "0x59C2170", VA = "0x1859C3570")] [MethodImpl(4096)] get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000081 RID: 129
		[Token(Token = "0x17000021")]
		public extern int pointCount { [Token(Token = "0x6000081")] [Address(RVA = "0x59C35F0", Offset = "0x59C21F0", VA = "0x1859C35F0")] [MethodImpl(4096)] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000082 RID: 130
		// (set) Token: 0x06000083 RID: 131
		[Token(Token = "0x17000022")]
		public extern Vector2[] points { [Token(Token = "0x6000082")] [Address(RVA = "0x59C3630", Offset = "0x59C2230", VA = "0x1859C3630")] [MethodImpl(4096)] get; [Token(Token = "0x6000083")] [Address(RVA = "0x59C3860", Offset = "0x59C2460", VA = "0x1859C3860")] [MethodImpl(4096)] set; }

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x59C3350", Offset = "0x59C1F50", VA = "0x1859C3350")]
		[NativeMethod("GetPoints_Binding")]
		[MethodImpl(4096)]
		public extern int GetPoints([NotNull("ArgumentNullException")] List<Vector2> points);

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x59C33E0", Offset = "0x59C1FE0", VA = "0x1859C33E0")]
		[NativeMethod("SetPoints_Binding")]
		[MethodImpl(4096)]
		public extern bool SetPoints([NotNull("ArgumentNullException")] List<Vector2> points);

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000086 RID: 134
		// (set) Token: 0x06000087 RID: 135
		[Token(Token = "0x17000023")]
		public extern bool useAdjacentStartPoint { [Token(Token = "0x6000086")] [Address(RVA = "0x59C36B0", Offset = "0x59C22B0", VA = "0x1859C36B0")] [MethodImpl(4096)] get; [Token(Token = "0x6000087")] [Address(RVA = "0x59C3900", Offset = "0x59C2500", VA = "0x1859C3900")] [MethodImpl(4096)] set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000088 RID: 136
		// (set) Token: 0x06000089 RID: 137
		[Token(Token = "0x17000024")]
		public extern bool useAdjacentEndPoint { [Token(Token = "0x6000088")] [Address(RVA = "0x59C3670", Offset = "0x59C2270", VA = "0x1859C3670")] [MethodImpl(4096)] get; [Token(Token = "0x6000089")] [Address(RVA = "0x59C38B0", Offset = "0x59C24B0", VA = "0x1859C38B0")] [MethodImpl(4096)] set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000254C File Offset: 0x0000074C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x17000025")]
		public Vector2 adjacentStartPoint
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x59C3520", Offset = "0x59C2120", VA = "0x1859C3520")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x59C37D0", Offset = "0x59C23D0", VA = "0x1859C37D0")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x17000026")]
		public Vector2 adjacentEndPoint
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x59C3480", Offset = "0x59C2080", VA = "0x1859C3480")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x59C3740", Offset = "0x59C2340", VA = "0x1859C3740")]
			set
			{
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000023E2 File Offset: 0x000005E2
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public EdgeCollider2D()
		{
		}

		// Token: 0x0600008F RID: 143
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x59C34D0", Offset = "0x59C20D0", VA = "0x1859C34D0")]
		[MethodImpl(4096)]
		private extern void get_adjacentStartPoint_Injected(out Vector2 ret);

		// Token: 0x06000090 RID: 144
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x59C3780", Offset = "0x59C2380", VA = "0x1859C3780")]
		[MethodImpl(4096)]
		private extern void set_adjacentStartPoint_Injected(ref Vector2 value);

		// Token: 0x06000091 RID: 145
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x59C3430", Offset = "0x59C2030", VA = "0x1859C3430")]
		[MethodImpl(4096)]
		private extern void get_adjacentEndPoint_Injected(out Vector2 ret);

		// Token: 0x06000092 RID: 146
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x59C36F0", Offset = "0x59C22F0", VA = "0x1859C36F0")]
		[MethodImpl(4096)]
		private extern void set_adjacentEndPoint_Injected(ref Vector2 value);
	}
}
