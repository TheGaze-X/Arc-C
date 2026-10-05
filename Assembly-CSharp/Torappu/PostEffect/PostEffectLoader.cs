using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using XLua;

namespace Torappu.PostEffect
{
	// Token: 0x02001458 RID: 5208
	[Token(Token = "0x2001458")]
	public class PostEffectLoader : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x060078B4 RID: 30900 RVA: 0x00036558 File Offset: 0x00034758
		[Token(Token = "0x17000E69")]
		public bool bloomEnabled
		{
			[Token(Token = "0x60078B4")]
			[Address(RVA = "0x2644460", Offset = "0x2643060", VA = "0x182644460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060078B5 RID: 30901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B5")]
		[Address(RVA = "0x26441D0", Offset = "0x2642DD0", VA = "0x1826441D0")]
		private void _OnSettingChanged(SettingConstVars.SettingType settingType)
		{
		}

		// Token: 0x060078B6 RID: 30902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B6")]
		[Address(RVA = "0x2644250", Offset = "0x2642E50", VA = "0x182644250")]
		private void _UpdateBloomStatus()
		{
		}

		// Token: 0x060078B7 RID: 30903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B7")]
		[Address(RVA = "0x2644070", Offset = "0x2642C70", VA = "0x182644070")]
		private void Start()
		{
		}

		// Token: 0x060078B8 RID: 30904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B8")]
		[Address(RVA = "0x2643F10", Offset = "0x2642B10", VA = "0x182643F10")]
		private void OnDestroy()
		{
		}

		// Token: 0x060078B9 RID: 30905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60078B9")]
		[Address(RVA = "0x2644400", Offset = "0x2643000", VA = "0x182644400")]
		public PostEffectLoader()
		{
		}

		// Token: 0x040076A2 RID: 30370
		[Token(Token = "0x40076A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _bloomEnabled;

		// Token: 0x040076A3 RID: 30371
		[Token(Token = "0x40076A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Inspect("bloomEnabled")]
		private MobileBloom.Settings _bloomSettings;

		// Token: 0x040076A4 RID: 30372
		[Token(Token = "0x40076A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useDepth;

		// Token: 0x040076A5 RID: 30373
		[Token(Token = "0x40076A5")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _useStencil;

		// Token: 0x040076A6 RID: 30374
		[Token(Token = "0x40076A6")]
		[FieldOffset(Offset = "0x30")]
		private MobileBloom m_bloom;

		// Token: 0x040076A7 RID: 30375
		[Token(Token = "0x40076A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bloomEnabled;

		// Token: 0x040076A8 RID: 30376
		[Token(Token = "0x40076A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnSettingChanged;

		// Token: 0x040076A9 RID: 30377
		[Token(Token = "0x40076A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateBloomStatus;

		// Token: 0x040076AA RID: 30378
		[Token(Token = "0x40076AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040076AB RID: 30379
		[Token(Token = "0x40076AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040076AC RID: 30380
		[Token(Token = "0x40076AC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
