using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003339 RID: 13113
	[Token(Token = "0x2003339")]
	public class UIBossHudRL3 : MonoBehaviour, IHotfixable
	{
		// Token: 0x170031A2 RID: 12706
		// (get) Token: 0x06014EAE RID: 85678 RVA: 0x000895F8 File Offset: 0x000877F8
		[Token(Token = "0x170031A2")]
		public bool actived
		{
			[Token(Token = "0x6014EAE")]
			[Address(RVA = "0xD59FC0", Offset = "0xD58BC0", VA = "0x180D59FC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031A3 RID: 12707
		// (get) Token: 0x06014EAF RID: 85679 RVA: 0x00089610 File Offset: 0x00087810
		[Token(Token = "0x170031A3")]
		public bool enemyValid
		{
			[Token(Token = "0x6014EAF")]
			[Address(RVA = "0xD5A020", Offset = "0xD58C20", VA = "0x180D5A020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170031A4 RID: 12708
		// (get) Token: 0x06014EB0 RID: 85680 RVA: 0x00089628 File Offset: 0x00087828
		// (set) Token: 0x06014EB1 RID: 85681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031A4")]
		public bool onSpellOn
		{
			[Token(Token = "0x6014EB0")]
			[Address(RVA = "0xD5A080", Offset = "0xD58C80", VA = "0x180D5A080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014EB1")]
			[Address(RVA = "0xD5A1A0", Offset = "0xD58DA0", VA = "0x180D5A1A0")]
			set
			{
			}
		}

		// Token: 0x170031A5 RID: 12709
		// (get) Token: 0x06014EB2 RID: 85682 RVA: 0x00089640 File Offset: 0x00087840
		// (set) Token: 0x06014EB3 RID: 85683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031A5")]
		public bool skillReady
		{
			[Token(Token = "0x6014EB2")]
			[Address(RVA = "0xD5A0E0", Offset = "0xD58CE0", VA = "0x180D5A0E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6014EB3")]
			[Address(RVA = "0xD5A210", Offset = "0xD58E10", VA = "0x180D5A210")]
			set
			{
			}
		}

		// Token: 0x170031A6 RID: 12710
		// (get) Token: 0x06014EB4 RID: 85684 RVA: 0x00089658 File Offset: 0x00087858
		// (set) Token: 0x06014EB5 RID: 85685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170031A6")]
		public FP skillRemainingTime
		{
			[Token(Token = "0x6014EB4")]
			[Address(RVA = "0xD5A140", Offset = "0xD58D40", VA = "0x180D5A140")]
			get
			{
				return default(FP);
			}
			[Token(Token = "0x6014EB5")]
			[Address(RVA = "0xD5A2A0", Offset = "0xD58EA0", VA = "0x180D5A2A0")]
			set
			{
			}
		}

		// Token: 0x06014EB6 RID: 85686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EB6")]
		[Address(RVA = "0xD59120", Offset = "0xD57D20", VA = "0x180D59120")]
		public void OnInit(UIRoguelikePluginRL3 plugin)
		{
		}

		// Token: 0x06014EB7 RID: 85687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EB7")]
		[Address(RVA = "0xD59270", Offset = "0xD57E70", VA = "0x180D59270")]
		public void SetData(Enemy enemy, EnemySkill enemySkill)
		{
		}

		// Token: 0x06014EB8 RID: 85688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EB8")]
		[Address(RVA = "0xD594E0", Offset = "0xD580E0", VA = "0x180D594E0")]
		public void UpdateData()
		{
		}

		// Token: 0x06014EB9 RID: 85689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EB9")]
		[Address(RVA = "0xD599B0", Offset = "0xD585B0", VA = "0x180D599B0")]
		private void _StartDeadTweenAnim()
		{
		}

		// Token: 0x06014EBA RID: 85690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014EBA")]
		[Address(RVA = "0xD59F60", Offset = "0xD58B60", VA = "0x180D59F60")]
		public UIBossHudRL3()
		{
		}

		// Token: 0x04018E07 RID: 101895
		[Token(Token = "0x4018E07")]
		private const float FADE_TIME = 0.35f;

		// Token: 0x04018E08 RID: 101896
		[Token(Token = "0x4018E08")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UITextSlider _spSlider;

		// Token: 0x04018E09 RID: 101897
		[Token(Token = "0x4018E09")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _avater;

		// Token: 0x04018E0A RID: 101898
		[Token(Token = "0x4018E0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _deadAvater;

		// Token: 0x04018E0B RID: 101899
		[Token(Token = "0x4018E0B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _deadSpImage;

		// Token: 0x04018E0C RID: 101900
		[Token(Token = "0x4018E0C")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Enemy> m_owner;

		// Token: 0x04018E0D RID: 101901
		[Token(Token = "0x4018E0D")]
		[FieldOffset(Offset = "0x48")]
		private EnemySkill m_enemySkill;

		// Token: 0x04018E0E RID: 101902
		[Token(Token = "0x4018E0E")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasActived;

		// Token: 0x04018E0F RID: 101903
		[Token(Token = "0x4018E0F")]
		[FieldOffset(Offset = "0x51")]
		private bool m_enemyValid;

		// Token: 0x04018E10 RID: 101904
		[Token(Token = "0x4018E10")]
		[FieldOffset(Offset = "0x58")]
		private FP m_skillRemainingTime;

		// Token: 0x04018E11 RID: 101905
		[Token(Token = "0x4018E11")]
		[FieldOffset(Offset = "0x60")]
		private bool m_onSpellOn;

		// Token: 0x04018E12 RID: 101906
		[Token(Token = "0x4018E12")]
		[FieldOffset(Offset = "0x61")]
		private bool m_skillReady;

		// Token: 0x04018E13 RID: 101907
		[Token(Token = "0x4018E13")]
		[FieldOffset(Offset = "0x68")]
		private UIRoguelikePluginRL3 m_plugin;

		// Token: 0x04018E14 RID: 101908
		[Token(Token = "0x4018E14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actived;

		// Token: 0x04018E15 RID: 101909
		[Token(Token = "0x4018E15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enemyValid;

		// Token: 0x04018E16 RID: 101910
		[Token(Token = "0x4018E16")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onSpellOn;

		// Token: 0x04018E17 RID: 101911
		[Token(Token = "0x4018E17")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onSpellOn;

		// Token: 0x04018E18 RID: 101912
		[Token(Token = "0x4018E18")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_skillReady;

		// Token: 0x04018E19 RID: 101913
		[Token(Token = "0x4018E19")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_skillReady;

		// Token: 0x04018E1A RID: 101914
		[Token(Token = "0x4018E1A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_skillRemainingTime;

		// Token: 0x04018E1B RID: 101915
		[Token(Token = "0x4018E1B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_skillRemainingTime;

		// Token: 0x04018E1C RID: 101916
		[Token(Token = "0x4018E1C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018E1D RID: 101917
		[Token(Token = "0x4018E1D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04018E1E RID: 101918
		[Token(Token = "0x4018E1E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04018E1F RID: 101919
		[Token(Token = "0x4018E1F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__StartDeadTweenAnim;

		// Token: 0x04018E20 RID: 101920
		[Token(Token = "0x4018E20")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
