using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Fx
{
	// Token: 0x0200203B RID: 8251
	[Token(Token = "0x200203B")]
	[RequireComponent(typeof(Renderer))]
	public class FxUVTweener : MonoBehaviour
	{
		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x0600CB59 RID: 52057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001816")]
		private Material activeMaterial
		{
			[Token(Token = "0x600CB59")]
			[Address(RVA = "0x34C6190", Offset = "0x34C4D90", VA = "0x1834C6190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x0600CB5A RID: 52058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001817")]
		private string secondMapPropertyName
		{
			[Token(Token = "0x600CB5A")]
			[Address(RVA = "0x34C6250", Offset = "0x34C4E50", VA = "0x1834C6250")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CB5B RID: 52059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB5B")]
		[Address(RVA = "0x34C5CF0", Offset = "0x34C48F0", VA = "0x1834C5CF0")]
		private void Awake()
		{
		}

		// Token: 0x0600CB5C RID: 52060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB5C")]
		[Address(RVA = "0x34C5ED0", Offset = "0x34C4AD0", VA = "0x1834C5ED0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CB5D RID: 52061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB5D")]
		[Address(RVA = "0x34C5F90", Offset = "0x34C4B90", VA = "0x1834C5F90")]
		private void Update()
		{
		}

		// Token: 0x0600CB5E RID: 52062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB5E")]
		[Address(RVA = "0x34C5E60", Offset = "0x34C4A60", VA = "0x1834C5E60")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CB5F RID: 52063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB5F")]
		[Address(RVA = "0x34C6140", Offset = "0x34C4D40", VA = "0x1834C6140")]
		public FxUVTweener()
		{
		}

		// Token: 0x0400D57A RID: 54650
		[Token(Token = "0x400D57A")]
		private const string MATERIAL_KEY = "FX_UV_TWEENER";

		// Token: 0x0400D57B RID: 54651
		[Token(Token = "0x400D57B")]
		private const float SPEED_SCALE = 2f;

		// Token: 0x0400D57C RID: 54652
		[Token(Token = "0x400D57C")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("动画是否从设置的初始位移开始播放, 是的话勾一下")]
		public bool keepInitOffset;

		// Token: 0x0400D57D RID: 54653
		[Token(Token = "0x400D57D")]
		[FieldOffset(Offset = "0x19")]
		public bool useSharedMaterial;

		// Token: 0x0400D57E RID: 54654
		[Token(Token = "0x400D57E")]
		[FieldOffset(Offset = "0x1A")]
		public bool protectMainUV;

		// Token: 0x0400D57F RID: 54655
		[Token(Token = "0x400D57F")]
		[FieldOffset(Offset = "0x1C")]
		public float xspeed;

		// Token: 0x0400D580 RID: 54656
		[Token(Token = "0x400D580")]
		[FieldOffset(Offset = "0x20")]
		public float yspeed;

		// Token: 0x0400D581 RID: 54657
		[Token(Token = "0x400D581")]
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public bool useSecondMap;

		// Token: 0x0400D582 RID: 54658
		[Token(Token = "0x400D582")]
		[FieldOffset(Offset = "0x25")]
		public bool protectSecondUV;

		// Token: 0x0400D583 RID: 54659
		[Token(Token = "0x400D583")]
		[FieldOffset(Offset = "0x28")]
		public string secondMapName;

		// Token: 0x0400D584 RID: 54660
		[Token(Token = "0x400D584")]
		[FieldOffset(Offset = "0x30")]
		public float secondXSpeed;

		// Token: 0x0400D585 RID: 54661
		[Token(Token = "0x400D585")]
		[FieldOffset(Offset = "0x34")]
		public float secondYSpeed;

		// Token: 0x0400D586 RID: 54662
		[Token(Token = "0x400D586")]
		[FieldOffset(Offset = "0x38")]
		private Material m_sharedMaterial;

		// Token: 0x0400D587 RID: 54663
		[Token(Token = "0x400D587")]
		[FieldOffset(Offset = "0x40")]
		private Renderer m_renderer;

		// Token: 0x0400D588 RID: 54664
		[Token(Token = "0x400D588")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 m_v2;

		// Token: 0x0400D589 RID: 54665
		[Token(Token = "0x400D589")]
		[FieldOffset(Offset = "0x50")]
		private Vector4 m_secondMapST;

		// Token: 0x0400D58A RID: 54666
		[Token(Token = "0x400D58A")]
		[FieldOffset(Offset = "0x60")]
		private string m_secondMapSTProp;

		// Token: 0x0400D58B RID: 54667
		[Token(Token = "0x400D58B")]
		[FieldOffset(Offset = "0x68")]
		private Material m_activeMaterial;
	}
}
