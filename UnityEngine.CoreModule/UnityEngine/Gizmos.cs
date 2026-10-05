using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[StaticAccessor("GizmoBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
	public sealed class Gizmos
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x5929DE0", Offset = "0x59289E0", VA = "0x185929DE0")]
		[NativeThrows]
		public static void DrawLine(Vector3 from, Vector3 to)
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x592A380", Offset = "0x5928F80", VA = "0x18592A380")]
		[NativeThrows]
		public static void DrawWireSphere(Vector3 center, float radius)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x592A0F0", Offset = "0x5928CF0", VA = "0x18592A0F0")]
		[NativeThrows]
		public static void DrawSphere(Vector3 center, float radius)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x592A190", Offset = "0x5928D90", VA = "0x18592A190")]
		[NativeThrows]
		public static void DrawWireCube(Vector3 center, Vector3 size)
		{
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x5929BF0", Offset = "0x59287F0", VA = "0x185929BF0")]
		[NativeThrows]
		public static void DrawCube(Vector3 center, Vector3 size)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x5929FB0", Offset = "0x5928BB0", VA = "0x185929FB0")]
		[NativeThrows]
		public static void DrawMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x592A240", Offset = "0x5928E40", VA = "0x18592A240")]
		[NativeThrows]
		public static void DrawWireMesh(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x5929D20", Offset = "0x5928920", VA = "0x185929D20")]
		[NativeThrows]
		public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x5929CB0", Offset = "0x59288B0", VA = "0x185929CB0")]
		[NativeThrows]
		public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] Color tint)
		{
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00002EE0 File Offset: 0x000010E0
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AA")]
		public static Color color
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x592A410", Offset = "0x5929010", VA = "0x18592A410")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x592A520", Offset = "0x5929120", VA = "0x18592A520")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public static Matrix4x4 matrix
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x592A490", Offset = "0x5929090", VA = "0x18592A490")]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x592A5A0", Offset = "0x59291A0", VA = "0x18592A5A0")]
			set
			{
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x5929E90", Offset = "0x5928A90", VA = "0x185929E90")]
		[ExcludeFromDocs]
		public static void DrawMesh(Mesh mesh)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x592A020", Offset = "0x5928C20", VA = "0x18592A020")]
		public static void DrawMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x592A2B0", Offset = "0x5928EB0", VA = "0x18592A2B0")]
		public static void DrawWireMesh(Mesh mesh, [DefaultValue("Vector3.zero")] Vector3 position, [DefaultValue("Quaternion.identity")] Quaternion rotation, [DefaultValue("Vector3.one")] Vector3 scale)
		{
		}

		// Token: 0x060002B1 RID: 689
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x5929D90", Offset = "0x5928990", VA = "0x185929D90")]
		[MethodImpl(4096)]
		private static extern void DrawLine_Injected(ref Vector3 from, ref Vector3 to);

		// Token: 0x060002B2 RID: 690
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x592A330", Offset = "0x5928F30", VA = "0x18592A330")]
		[MethodImpl(4096)]
		private static extern void DrawWireSphere_Injected(ref Vector3 center, float radius);

		// Token: 0x060002B3 RID: 691
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x592A0A0", Offset = "0x5928CA0", VA = "0x18592A0A0")]
		[MethodImpl(4096)]
		private static extern void DrawSphere_Injected(ref Vector3 center, float radius);

		// Token: 0x060002B4 RID: 692
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x592A140", Offset = "0x5928D40", VA = "0x18592A140")]
		[MethodImpl(4096)]
		private static extern void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size);

		// Token: 0x060002B5 RID: 693
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x5929BA0", Offset = "0x59287A0", VA = "0x185929BA0")]
		[MethodImpl(4096)]
		private static extern void DrawCube_Injected(ref Vector3 center, ref Vector3 size);

		// Token: 0x060002B6 RID: 694
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x5929E30", Offset = "0x5928A30", VA = "0x185929E30")]
		[MethodImpl(4096)]
		private static extern void DrawMesh_Injected(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] ref Vector3 position, [DefaultValue("Quaternion.identity")] ref Quaternion rotation, [DefaultValue("Vector3.one")] ref Vector3 scale);

		// Token: 0x060002B7 RID: 695
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x592A1E0", Offset = "0x5928DE0", VA = "0x18592A1E0")]
		[MethodImpl(4096)]
		private static extern void DrawWireMesh_Injected(Mesh mesh, int submeshIndex, [DefaultValue("Vector3.zero")] ref Vector3 position, [DefaultValue("Quaternion.identity")] ref Quaternion rotation, [DefaultValue("Vector3.one")] ref Vector3 scale);

		// Token: 0x060002B8 RID: 696
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x5929C40", Offset = "0x5928840", VA = "0x185929C40")]
		[MethodImpl(4096)]
		private static extern void DrawIcon_Injected(ref Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] ref Color tint);

		// Token: 0x060002B9 RID: 697
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x592A3D0", Offset = "0x5928FD0", VA = "0x18592A3D0")]
		[MethodImpl(4096)]
		private static extern void get_color_Injected(out Color ret);

		// Token: 0x060002BA RID: 698
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x592A4E0", Offset = "0x59290E0", VA = "0x18592A4E0")]
		[MethodImpl(4096)]
		private static extern void set_color_Injected(ref Color value);

		// Token: 0x060002BB RID: 699
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x592A450", Offset = "0x5929050", VA = "0x18592A450")]
		[MethodImpl(4096)]
		private static extern void get_matrix_Injected(out Matrix4x4 ret);

		// Token: 0x060002BC RID: 700
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x592A560", Offset = "0x5929160", VA = "0x18592A560")]
		[MethodImpl(4096)]
		private static extern void set_matrix_Injected(ref Matrix4x4 value);
	}
}
