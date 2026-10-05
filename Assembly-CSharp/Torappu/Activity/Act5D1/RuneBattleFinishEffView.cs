using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200722C RID: 29228
	[Token(Token = "0x200722C")]
	public class RuneBattleFinishEffView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700621D RID: 25117
		// (get) Token: 0x060296C1 RID: 169665 RVA: 0x000D5A38 File Offset: 0x000D3C38
		// (set) Token: 0x060296C2 RID: 169666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700621D")]
		public bool EffectEndFlag
		{
			[Token(Token = "0x60296C1")]
			[Address(RVA = "0x24D4B20", Offset = "0x24D3720", VA = "0x1824D4B20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60296C2")]
			[Address(RVA = "0x24D4BE0", Offset = "0x24D37E0", VA = "0x1824D4BE0")]
			set
			{
			}
		}

		// Token: 0x1700621E RID: 25118
		// (get) Token: 0x060296C3 RID: 169667 RVA: 0x000D5A50 File Offset: 0x000D3C50
		// (set) Token: 0x060296C4 RID: 169668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700621E")]
		public bool IsClosed
		{
			[Token(Token = "0x60296C3")]
			[Address(RVA = "0x24D4B80", Offset = "0x24D3780", VA = "0x1824D4B80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60296C4")]
			[Address(RVA = "0x24D4C50", Offset = "0x24D3850", VA = "0x1824D4C50")]
			set
			{
			}
		}

		// Token: 0x060296C5 RID: 169669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296C5")]
		[Address(RVA = "0x24D4850", Offset = "0x24D3450", VA = "0x1824D4850")]
		public void Init(RuneBattleFinishStateBean stateBean)
		{
		}

		// Token: 0x060296C6 RID: 169670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60296C6")]
		[Address(RVA = "0x24D4A10", Offset = "0x24D3610", VA = "0x1824D4A10")]
		public IEnumerator PlayEffect()
		{
			return null;
		}

		// Token: 0x060296C7 RID: 169671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296C7")]
		[Address(RVA = "0x24D47D0", Offset = "0x24D33D0", VA = "0x1824D47D0")]
		public void Hide()
		{
		}

		// Token: 0x060296C8 RID: 169672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296C8")]
		[Address(RVA = "0x24D4AC0", Offset = "0x24D36C0", VA = "0x1824D4AC0")]
		public RuneBattleFinishEffView()
		{
		}

		// Token: 0x0403B299 RID: 242329
		[Token(Token = "0x403B299")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIBlurFloatPanel _backImage;

		// Token: 0x0403B29A RID: 242330
		[Token(Token = "0x403B29A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _spriteLogo;

		// Token: 0x0403B29B RID: 242331
		[Token(Token = "0x403B29B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x0403B29C RID: 242332
		[Token(Token = "0x403B29C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stageDesc;

		// Token: 0x0403B29D RID: 242333
		[Token(Token = "0x403B29D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _runeValue;

		// Token: 0x0403B29E RID: 242334
		[Token(Token = "0x403B29E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ParticleSystem _psItem;

		// Token: 0x0403B29F RID: 242335
		[Token(Token = "0x403B29F")]
		[FieldOffset(Offset = "0x48")]
		private bool m_effectEndFlag;

		// Token: 0x0403B2A0 RID: 242336
		[Token(Token = "0x403B2A0")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isClosed;

		// Token: 0x0403B2A1 RID: 242337
		[Token(Token = "0x403B2A1")]
		private const float PASTTIME = 0.2f;

		// Token: 0x0403B2A2 RID: 242338
		[Token(Token = "0x403B2A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_EffectEndFlag;

		// Token: 0x0403B2A3 RID: 242339
		[Token(Token = "0x403B2A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_EffectEndFlag;

		// Token: 0x0403B2A4 RID: 242340
		[Token(Token = "0x403B2A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_IsClosed;

		// Token: 0x0403B2A5 RID: 242341
		[Token(Token = "0x403B2A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_IsClosed;

		// Token: 0x0403B2A6 RID: 242342
		[Token(Token = "0x403B2A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403B2A7 RID: 242343
		[Token(Token = "0x403B2A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayEffect;

		// Token: 0x0403B2A8 RID: 242344
		[Token(Token = "0x403B2A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403B2A9 RID: 242345
		[Token(Token = "0x403B2A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
