using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[AddComponentMenu("CRIWARE/CRI Atom Region")]
	[DisallowMultipleComponent]
	public class CriAtomRegion : CriMonoBehaviour
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000100 RID: 256 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001A")]
		public CriAtomEx3dRegion region3dHn
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x5D55A0", Offset = "0x5D41A0", VA = "0x1805D55A0")]
		private void Awake()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x36D32A0", Offset = "0x36D1EA0", VA = "0x1836D32A0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x36D3260", Offset = "0x36D1E60", VA = "0x1836D3260")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x36D30D0", Offset = "0x36D1CD0", VA = "0x1836D30D0", Slot = "8")]
		protected virtual void InternalInitialize()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x36D2E50", Offset = "0x36D1A50", VA = "0x1836D2E50", Slot = "9")]
		protected virtual void InternalFinalize()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x36D2DE0", Offset = "0x36D19E0", VA = "0x1836D2DE0", Slot = "10")]
		protected virtual void InitializeParameters()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public override void CriInternalUpdate()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		public override void CriInternalLateUpdate()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x36D32E0", Offset = "0x36D1EE0", VA = "0x1836D32E0")]
		public CriAtomRegion()
		{
		}

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x30")]
		internal List<CriAtomSourceBase> referringSources;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x38")]
		internal List<CriAtomListener> referringListeners;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x40")]
		internal List<CriAtomTransceiver> referringTransceivers;
	}
}
