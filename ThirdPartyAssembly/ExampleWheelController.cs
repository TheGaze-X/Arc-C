using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
public class ExampleWheelController : MonoBehaviour
{
	// Token: 0x06000107 RID: 263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x51BE0A0", Offset = "0x51BCCA0", VA = "0x1851BE0A0")]
	private void Start()
	{
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x51BE110", Offset = "0x51BCD10", VA = "0x1851BE110")]
	private void Update()
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
	public ExampleWheelController()
	{
	}

	// Token: 0x04000092 RID: 146
	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x18")]
	public float acceleration;

	// Token: 0x04000093 RID: 147
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x20")]
	public Renderer motionVectorRenderer;

	// Token: 0x04000094 RID: 148
	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody m_Rigidbody;

	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	private static class Uniforms
	{
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int _MotionAmount;
	}
}
