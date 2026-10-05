using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000554 RID: 1364
	[Token(Token = "0x2000554")]
	public class FurnitureOutline : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06005ACC RID: 23244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C99")]
		protected MaterialPropertyBlock propertyBlock
		{
			[Token(Token = "0x6005ACC")]
			[Address(RVA = "0x1AF0810", Offset = "0x1AEF410", VA = "0x181AF0810")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06005ACD RID: 23245 RVA: 0x0002EAD0 File Offset: 0x0002CCD0
		// (set) Token: 0x06005ACE RID: 23246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9A")]
		public bool isHighlight
		{
			[Token(Token = "0x6005ACD")]
			[Address(RVA = "0x1AF07B0", Offset = "0x1AEF3B0", VA = "0x181AF07B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005ACE")]
			[Address(RVA = "0x1AF08C0", Offset = "0x1AEF4C0", VA = "0x181AF08C0")]
			set
			{
			}
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACF")]
		[Address(RVA = "0x1AF04B0", Offset = "0x1AEF0B0", VA = "0x181AF04B0")]
		public void ResetOutLine()
		{
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD0")]
		[Address(RVA = "0x1AF0560", Offset = "0x1AEF160", VA = "0x181AF0560")]
		private void _ResetInternal()
		{
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x0002EAE8 File Offset: 0x0002CCE8
		[Token(Token = "0x6005AD1")]
		[Address(RVA = "0x1AEFF10", Offset = "0x1AEEB10", VA = "0x181AEFF10")]
		public bool Init(MeshRenderer meshRenderer)
		{
			return default(bool);
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x0002EB00 File Offset: 0x0002CD00
		[Token(Token = "0x6005AD2")]
		[Address(RVA = "0x1AEFC50", Offset = "0x1AEE850", VA = "0x181AEFC50")]
		public bool Init(SkinnedMeshRenderer skinnedMeshRenderer)
		{
			return default(bool);
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0x1AF01D0", Offset = "0x1AEEDD0", VA = "0x181AF01D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD4")]
		[Address(RVA = "0x1AF0730", Offset = "0x1AEF330", VA = "0x181AF0730")]
		public FurnitureOutline()
		{
		}

		// Token: 0x0400208A RID: 8330
		[Token(Token = "0x400208A")]
		private const string SHADER_PROPERTY_OUTLINE_COLOR = "_OutlineColor";

		// Token: 0x0400208B RID: 8331
		[Token(Token = "0x400208B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color _outlineColor;

		// Token: 0x0400208C RID: 8332
		[Token(Token = "0x400208C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeTime;

		// Token: 0x0400208D RID: 8333
		[Token(Token = "0x400208D")]
		[FieldOffset(Offset = "0x30")]
		private MeshRenderer m_meshRenderer;

		// Token: 0x0400208E RID: 8334
		[Token(Token = "0x400208E")]
		[FieldOffset(Offset = "0x38")]
		private SkinnedMeshRenderer m_skinnedMeshRenderer;

		// Token: 0x0400208F RID: 8335
		[Token(Token = "0x400208F")]
		[FieldOffset(Offset = "0x40")]
		private Material m_material;

		// Token: 0x04002090 RID: 8336
		[Token(Token = "0x4002090")]
		[FieldOffset(Offset = "0x48")]
		private float m_fadeTimer;

		// Token: 0x04002091 RID: 8337
		[Token(Token = "0x4002091")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isFinished;

		// Token: 0x04002092 RID: 8338
		[Token(Token = "0x4002092")]
		[FieldOffset(Offset = "0x4D")]
		private bool m_isHighlight;

		// Token: 0x04002093 RID: 8339
		[Token(Token = "0x4002093")]
		[FieldOffset(Offset = "0x50")]
		private Color m_outlineColor;

		// Token: 0x04002094 RID: 8340
		[Token(Token = "0x4002094")]
		[FieldOffset(Offset = "0x60")]
		private MaterialPropertyBlock m_propertyBlock;

		// Token: 0x04002095 RID: 8341
		[Token(Token = "0x4002095")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_propertyBlock;

		// Token: 0x04002096 RID: 8342
		[Token(Token = "0x4002096")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isHighlight;

		// Token: 0x04002097 RID: 8343
		[Token(Token = "0x4002097")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isHighlight;

		// Token: 0x04002098 RID: 8344
		[Token(Token = "0x4002098")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetOutLine;

		// Token: 0x04002099 RID: 8345
		[Token(Token = "0x4002099")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetInternal;

		// Token: 0x0400209A RID: 8346
		[Token(Token = "0x400209A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400209B RID: 8347
		[Token(Token = "0x400209B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x0400209C RID: 8348
		[Token(Token = "0x400209C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x0400209D RID: 8349
		[Token(Token = "0x400209D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
