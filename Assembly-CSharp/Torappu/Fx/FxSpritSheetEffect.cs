using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Fx
{
	// Token: 0x02002039 RID: 8249
	[Token(Token = "0x2002039")]
	[RequireComponent(typeof(Renderer))]
	public class FxSpritSheetEffect : MonoBehaviour
	{
		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x0600CB47 RID: 52039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001810")]
		private Material VaryingMaterial
		{
			[Token(Token = "0x600CB47")]
			[Address(RVA = "0x34C4640", Offset = "0x34C3240", VA = "0x1834C4640")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CB48 RID: 52040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB48")]
		[Address(RVA = "0x34C43B0", Offset = "0x34C2FB0", VA = "0x1834C43B0")]
		private void Start()
		{
		}

		// Token: 0x0600CB49 RID: 52041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB49")]
		[Address(RVA = "0x34C4450", Offset = "0x34C3050", VA = "0x1834C4450")]
		private void Update()
		{
		}

		// Token: 0x0600CB4A RID: 52042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB4A")]
		[Address(RVA = "0x34C43A0", Offset = "0x34C2FA0", VA = "0x1834C43A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB4B RID: 52043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB4B")]
		[Address(RVA = "0x34C4300", Offset = "0x34C2F00", VA = "0x1834C4300")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CB4C RID: 52044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB4C")]
		[Address(RVA = "0x34C45D0", Offset = "0x34C31D0", VA = "0x1834C45D0")]
		public FxSpritSheetEffect()
		{
		}

		// Token: 0x0400D554 RID: 54612
		[Token(Token = "0x400D554")]
		[FieldOffset(Offset = "0x18")]
		public int row;

		// Token: 0x0400D555 RID: 54613
		[Token(Token = "0x400D555")]
		[FieldOffset(Offset = "0x1C")]
		public int column;

		// Token: 0x0400D556 RID: 54614
		[Token(Token = "0x400D556")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		// Token: 0x0400D557 RID: 54615
		[Token(Token = "0x400D557")]
		[FieldOffset(Offset = "0x24")]
		public bool loop;

		// Token: 0x0400D558 RID: 54616
		[Token(Token = "0x400D558")]
		[FieldOffset(Offset = "0x28")]
		private float m_time;

		// Token: 0x0400D559 RID: 54617
		[Token(Token = "0x400D559")]
		[FieldOffset(Offset = "0x2C")]
		private float m_perFrameTime;

		// Token: 0x0400D55A RID: 54618
		[Token(Token = "0x400D55A")]
		[FieldOffset(Offset = "0x30")]
		private int m_totalFrameNum;

		// Token: 0x0400D55B RID: 54619
		[Token(Token = "0x400D55B")]
		[FieldOffset(Offset = "0x34")]
		private readonly int HG_FX_OUT_CTRL_PROP;

		// Token: 0x0400D55C RID: 54620
		[Token(Token = "0x400D55C")]
		[FieldOffset(Offset = "0x38")]
		private readonly int HG_FX_SPRITE_SHEET_PARAM_PROP;

		// Token: 0x0400D55D RID: 54621
		[Token(Token = "0x400D55D")]
		[FieldOffset(Offset = "0x40")]
		private Material m_varyingMaterial;
	}
}
