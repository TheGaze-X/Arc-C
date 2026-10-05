using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Test
{
	// Token: 0x02005C20 RID: 23584
	[Token(Token = "0x2005C20")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class UIDynIllustEditorView : MonoBehaviour
	{
		// Token: 0x06022312 RID: 140050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022312")]
		[Address(RVA = "0x1CB6900", Offset = "0x1CB5500", VA = "0x181CB6900")]
		private void Awake()
		{
		}

		// Token: 0x06022313 RID: 140051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022313")]
		[Address(RVA = "0x1CB69A0", Offset = "0x1CB55A0", VA = "0x181CB69A0")]
		public void Update()
		{
		}

		// Token: 0x06022314 RID: 140052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022314")]
		[Address(RVA = "0x1CB7120", Offset = "0x1CB5D20", VA = "0x181CB7120")]
		private void _InitDisplay()
		{
		}

		// Token: 0x06022315 RID: 140053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022315")]
		[Address(RVA = "0x1CB6FD0", Offset = "0x1CB5BD0", VA = "0x181CB6FD0")]
		private DynIllustView _CreateIllustView(DynIllustBase res, Transform parent)
		{
			return null;
		}

		// Token: 0x06022316 RID: 140054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022316")]
		[Address(RVA = "0x1CB72B0", Offset = "0x1CB5EB0", VA = "0x181CB72B0")]
		public UIDynIllustEditorView()
		{
		}

		// Token: 0x0402EE69 RID: 192105
		[Token(Token = "0x402EE69")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _battleView;

		// Token: 0x0402EE6A RID: 192106
		[Token(Token = "0x402EE6A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _charInfoView;

		// Token: 0x0402EE6B RID: 192107
		[Token(Token = "0x402EE6B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _skinView;

		// Token: 0x0402EE6C RID: 192108
		[Token(Token = "0x402EE6C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _homeView;

		// Token: 0x0402EE6D RID: 192109
		[Token(Token = "0x402EE6D")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_cam;

		// Token: 0x0402EE6E RID: 192110
		[Token(Token = "0x402EE6E")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_rt;

		// Token: 0x0402EE6F RID: 192111
		[Token(Token = "0x402EE6F")]
		[FieldOffset(Offset = "0x48")]
		private Material m_mat;

		// Token: 0x0402EE70 RID: 192112
		[Token(Token = "0x402EE70")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[ReadOnly]
		private bool _attached;

		// Token: 0x0402EE71 RID: 192113
		[Token(Token = "0x402EE71")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[ReadOnly]
		private List<DynIllustView> _views;

		// Token: 0x0402EE72 RID: 192114
		[Token(Token = "0x402EE72")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[ReadOnly]
		private int _skinIdx;

		// Token: 0x0402EE73 RID: 192115
		[Token(Token = "0x402EE73")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[ReadOnly]
		private int _homeIdx;
	}
}
