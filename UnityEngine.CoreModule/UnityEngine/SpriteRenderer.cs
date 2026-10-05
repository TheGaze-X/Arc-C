using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	[RequireComponent(typeof(Transform))]
	[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
	public sealed class SpriteRenderer : Renderer
	{
		// Token: 0x06000BD8 RID: 3032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x596D0B0", Offset = "0x596BCB0", VA = "0x18596D0B0")]
		[RequiredByNativeCode]
		private void InvokeSpriteChanged()
		{
		}

		// Token: 0x17000276 RID: 630
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000276")]
		public Vector2 size
		{
			[Token(Token = "0x6000BD9")]
			[Address(RVA = "0x596D2C0", Offset = "0x596BEC0", VA = "0x18596D2C0")]
			set
			{
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000277")]
		public Color color
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x596D180", Offset = "0x596BD80", VA = "0x18596D180")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x596D220", Offset = "0x596BE20", VA = "0x18596D220")]
			set
			{
			}
		}

		// Token: 0x06000BDC RID: 3036
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x596D270", Offset = "0x596BE70", VA = "0x18596D270")]
		[MethodImpl(4096)]
		private extern void set_size_Injected(ref Vector2 value);

		// Token: 0x06000BDD RID: 3037
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x596D130", Offset = "0x596BD30", VA = "0x18596D130")]
		[MethodImpl(4096)]
		private extern void get_color_Injected(out Color ret);

		// Token: 0x06000BDE RID: 3038
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x596D1D0", Offset = "0x596BDD0", VA = "0x18596D1D0")]
		[MethodImpl(4096)]
		private extern void set_color_Injected(ref Color value);

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x18")]
		private UnityEvent<SpriteRenderer> m_SpriteChangeEvent;
	}
}
