using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AA7 RID: 27303
	[Token(Token = "0x2006AA7")]
	public class ActArchiveCompDataBinder : DataBinder<IntProperty>, IHotfixable
	{
		// Token: 0x17005C48 RID: 23624
		// (get) Token: 0x060270ED RID: 159981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C48")]
		private ActArchiveInfo _archiveInfo
		{
			[Token(Token = "0x60270ED")]
			[Address(RVA = "0x2233F80", Offset = "0x2232B80", VA = "0x182233F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060270EE RID: 159982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270EE")]
		[Address(RVA = "0x22335D0", Offset = "0x22321D0", VA = "0x1822335D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060270EF RID: 159983 RVA: 0x000CD608 File Offset: 0x000CB808
		[Token(Token = "0x60270EF")]
		[Address(RVA = "0x2233220", Offset = "0x2231E20", VA = "0x182233220")]
		private bool _GetProxyByArchiveType(ActArchiveType archiveType, out ActArchiveProxy proxy)
		{
			return default(bool);
		}

		// Token: 0x060270F0 RID: 159984 RVA: 0x000CD620 File Offset: 0x000CB820
		[Token(Token = "0x60270F0")]
		[Address(RVA = "0x22337B0", Offset = "0x22323B0", VA = "0x1822337B0")]
		private bool _LockTransition()
		{
			return default(bool);
		}

		// Token: 0x060270F1 RID: 159985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270F1")]
		[Address(RVA = "0x2233830", Offset = "0x2232430", VA = "0x182233830")]
		private void _UnlockTransition()
		{
		}

		// Token: 0x060270F2 RID: 159986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270F2")]
		[Address(RVA = "0x2232FF0", Offset = "0x2231BF0", VA = "0x182232FF0", Slot = "7")]
		public override void OnValueChanged(IntProperty property)
		{
		}

		// Token: 0x060270F3 RID: 159987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270F3")]
		[Address(RVA = "0x2233140", Offset = "0x2231D40", VA = "0x182233140")]
		public IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x060270F4 RID: 159988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270F4")]
		[Address(RVA = "0x2232F10", Offset = "0x2231B10", VA = "0x182232F10")]
		public void NotifyBeforePageHide(bool isIntoStack)
		{
		}

		// Token: 0x060270F5 RID: 159989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270F5")]
		[Address(RVA = "0x2233EA0", Offset = "0x2232AA0", VA = "0x182233EA0")]
		public ActArchiveCompDataBinder()
		{
		}

		// Token: 0x04037473 RID: 226419
		[Token(Token = "0x4037473")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ActArchiveType, Type> PROXY_TYPE_DICT;

		// Token: 0x04037474 RID: 226420
		[Token(Token = "0x4037474")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _compHolder;

		// Token: 0x04037475 RID: 226421
		[Token(Token = "0x4037475")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _topHolder;

		// Token: 0x04037476 RID: 226422
		[Token(Token = "0x4037476")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private State _state;

		// Token: 0x04037477 RID: 226423
		[Token(Token = "0x4037477")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public List<ActArchiveType> _supportedTypes;

		// Token: 0x04037478 RID: 226424
		[Token(Token = "0x4037478")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ActArchiveType, ActArchiveProxy> m_proxies;

		// Token: 0x04037479 RID: 226425
		[Token(Token = "0x4037479")]
		[FieldOffset(Offset = "0x48")]
		private ActArchiveType m_selectedComp;

		// Token: 0x0403747A RID: 226426
		[Token(Token = "0x403747A")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isTransitting;

		// Token: 0x0403747B RID: 226427
		[Token(Token = "0x403747B")]
		[FieldOffset(Offset = "0x4D")]
		private bool m_isInited;

		// Token: 0x0403747C RID: 226428
		[Token(Token = "0x403747C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get__archiveInfo;

		// Token: 0x0403747D RID: 226429
		[Token(Token = "0x403747D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403747E RID: 226430
		[Token(Token = "0x403747E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetProxyByArchiveType;

		// Token: 0x0403747F RID: 226431
		[Token(Token = "0x403747F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LockTransition;

		// Token: 0x04037480 RID: 226432
		[Token(Token = "0x4037480")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UnlockTransition;

		// Token: 0x04037481 RID: 226433
		[Token(Token = "0x4037481")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037482 RID: 226434
		[Token(Token = "0x4037482")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04037483 RID: 226435
		[Token(Token = "0x4037483")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NotifyBeforePageHide;

		// Token: 0x04037484 RID: 226436
		[Token(Token = "0x4037484")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
