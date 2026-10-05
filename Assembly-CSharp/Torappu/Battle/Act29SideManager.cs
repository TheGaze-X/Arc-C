using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.Battle.Effects;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022B8 RID: 8888
	[Token(Token = "0x20022B8")]
	public class Act29SideManager : GlobalEnvSystem.EnvManager, IBuffSource, IHotfixable
	{
		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x0600DF68 RID: 57192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C05")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600DF68")]
			[Address(RVA = "0x3649090", Offset = "0x3647C90", VA = "0x183649090", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x0600DF69 RID: 57193 RVA: 0x00051288 File Offset: 0x0004F488
		[Token(Token = "0x17001C06")]
		public Act29SideManager.AudioType currentAudioType
		{
			[Token(Token = "0x600DF69")]
			[Address(RVA = "0x3648F70", Offset = "0x3647B70", VA = "0x183648F70")]
			get
			{
				return Act29SideManager.AudioType.None;
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x0600DF6A RID: 57194 RVA: 0x000512A0 File Offset: 0x0004F4A0
		[Token(Token = "0x17001C07")]
		public float audioBuffRamainingTime
		{
			[Token(Token = "0x600DF6A")]
			[Address(RVA = "0x3648C90", Offset = "0x3647890", VA = "0x183648C90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x0600DF6B RID: 57195 RVA: 0x000512B8 File Offset: 0x0004F4B8
		[Token(Token = "0x17001C08")]
		public float audioTypeRamainingTime
		{
			[Token(Token = "0x600DF6B")]
			[Address(RVA = "0x3648D50", Offset = "0x3647950", VA = "0x183648D50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x0600DF6C RID: 57196 RVA: 0x000512D0 File Offset: 0x0004F4D0
		[Token(Token = "0x17001C09")]
		public int currentStage
		{
			[Token(Token = "0x600DF6C")]
			[Address(RVA = "0x3648FD0", Offset = "0x3647BD0", VA = "0x183648FD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x0600DF6D RID: 57197 RVA: 0x000512E8 File Offset: 0x0004F4E8
		[Token(Token = "0x17001C0A")]
		public bool isControlledByBoss
		{
			[Token(Token = "0x600DF6D")]
			[Address(RVA = "0x36493C0", Offset = "0x3647FC0", VA = "0x1836493C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x0600DF6E RID: 57198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C0B")]
		public List<float> switchIntervalList
		{
			[Token(Token = "0x600DF6E")]
			[Address(RVA = "0x3649420", Offset = "0x3648020", VA = "0x183649420")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x0600DF6F RID: 57199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C0C")]
		public List<float> durationAudioBuff
		{
			[Token(Token = "0x600DF6F")]
			[Address(RVA = "0x3649030", Offset = "0x3647C30", VA = "0x183649030")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x0600DF70 RID: 57200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C0D")]
		public List<Act29SideManager.AudioType> switchSideList
		{
			[Token(Token = "0x600DF70")]
			[Address(RVA = "0x3649480", Offset = "0x3648080", VA = "0x183649480")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x0600DF71 RID: 57201 RVA: 0x00051300 File Offset: 0x0004F500
		// (set) Token: 0x0600DF72 RID: 57202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001C0E")]
		public bool uiSignalTriggeredSkillManually
		{
			[Token(Token = "0x600DF71")]
			[Address(RVA = "0x36494E0", Offset = "0x36480E0", VA = "0x1836494E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600DF72")]
			[Address(RVA = "0x3649540", Offset = "0x3648140", VA = "0x183649540")]
			set
			{
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x0600DF73 RID: 57203 RVA: 0x00051318 File Offset: 0x0004F518
		[Token(Token = "0x17001C0F")]
		public bool isBossDead
		{
			[Token(Token = "0x600DF73")]
			[Address(RVA = "0x3649360", Offset = "0x3647F60", VA = "0x183649360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x0600DF74 RID: 57204 RVA: 0x00051330 File Offset: 0x0004F530
		[Token(Token = "0x17001C10")]
		public float bossAudioBuffTime
		{
			[Token(Token = "0x600DF74")]
			[Address(RVA = "0x3648F10", Offset = "0x3647B10", VA = "0x183648F10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x0600DF75 RID: 57205 RVA: 0x00051348 File Offset: 0x0004F548
		[Token(Token = "0x17001C11")]
		public float bossAudioBuffProgress
		{
			[Token(Token = "0x600DF75")]
			[Address(RVA = "0x3648E20", Offset = "0x3647A20", VA = "0x183648E20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600DF76 RID: 57206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF76")]
		[Address(RVA = "0x3646DD0", Offset = "0x36459D0", VA = "0x183646DD0", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600DF77 RID: 57207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF77")]
		[Address(RVA = "0x3647420", Offset = "0x3646020", VA = "0x183647420", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600DF78 RID: 57208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF78")]
		[Address(RVA = "0x3646CF0", Offset = "0x36458F0", VA = "0x183646CF0", Slot = "10")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600DF79 RID: 57209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF79")]
		[Address(RVA = "0x3647BF0", Offset = "0x36467F0", VA = "0x183647BF0")]
		public void RegisterPortalTraps(Trap trap)
		{
		}

		// Token: 0x0600DF7A RID: 57210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF7A")]
		[Address(RVA = "0x3647FF0", Offset = "0x3646BF0", VA = "0x183647FF0")]
		public void SwitchAudioTypeManually()
		{
		}

		// Token: 0x0600DF7B RID: 57211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF7B")]
		[Address(RVA = "0x3647C90", Offset = "0x3646890", VA = "0x183647C90")]
		public void SwitchAudioByBoss(Act29SideManager.AudioType audioType, float audioBuffDuration, bool firstTime, bool toOpposite)
		{
		}

		// Token: 0x0600DF7C RID: 57212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF7C")]
		[Address(RVA = "0x3647230", Offset = "0x3645E30", VA = "0x183647230")]
		public void MuteAll()
		{
		}

		// Token: 0x0600DF7D RID: 57213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF7D")]
		[Address(RVA = "0x36473B0", Offset = "0x3645FB0", VA = "0x1836473B0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0600DF7E RID: 57214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF7E")]
		[Address(RVA = "0x3648470", Offset = "0x3647070", VA = "0x183648470")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600DF7F RID: 57215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF7F")]
		[Address(RVA = "0x36483F0", Offset = "0x3646FF0", VA = "0x1836483F0")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x0600DF80 RID: 57216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF80")]
		[Address(RVA = "0x3648370", Offset = "0x3646F70", VA = "0x183648370")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600DF81 RID: 57217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF81")]
		[Address(RVA = "0x3648640", Offset = "0x3647240", VA = "0x183648640")]
		private void _ProcessBlackboard()
		{
		}

		// Token: 0x0600DF82 RID: 57218 RVA: 0x00051360 File Offset: 0x0004F560
		[Token(Token = "0x600DF82")]
		[Address(RVA = "0x36482E0", Offset = "0x3646EE0", VA = "0x1836482E0")]
		private Act29SideManager.AudioType _NextSwitchSide(int currentStage)
		{
			return Act29SideManager.AudioType.None;
		}

		// Token: 0x0600DF83 RID: 57219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF83")]
		[Address(RVA = "0x3648A90", Offset = "0x3647690", VA = "0x183648A90")]
		private void _ResetSwitchTimer(int currentStage)
		{
		}

		// Token: 0x0600DF84 RID: 57220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF84")]
		[Address(RVA = "0x3648990", Offset = "0x3647590", VA = "0x183648990")]
		private void _ResetAudioBuffDurationTimer(int currentStage)
		{
		}

		// Token: 0x0600DF85 RID: 57221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF85")]
		[Address(RVA = "0x3648140", Offset = "0x3646D40", VA = "0x183648140")]
		private void _ActiveProperPortalTrap()
		{
		}

		// Token: 0x0600DF86 RID: 57222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF86")]
		[Address(RVA = "0x3648B90", Offset = "0x3647790", VA = "0x183648B90")]
		public Act29SideManager()
		{
		}

		// Token: 0x0600DF87 RID: 57223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DF87")]
		[Address(RVA = "0x3642D70", Offset = "0x3641970", VA = "0x183642D70")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600DF88 RID: 57224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF88")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DF89 RID: 57225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF89")]
		[Address(RVA = "0x36480E0", Offset = "0x3646CE0", VA = "0x1836480E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600DF8A RID: 57226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DF8A")]
		[Address(RVA = "0x3648080", Offset = "0x3646C80", VA = "0x183648080")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0400F2AD RID: 62125
		[Token(Token = "0x400F2AD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Trap Ctrl")]
		private BuffData _portalTrapsActiveBuff;

		// Token: 0x0400F2AE RID: 62126
		[Token(Token = "0x400F2AE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Camera Effect")]
		private string _enthuCamEff;

		// Token: 0x0400F2AF RID: 62127
		[Token(Token = "0x400F2AF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Camera Effect")]
		private string _depressedCamEff;

		// Token: 0x0400F2B0 RID: 62128
		[Token(Token = "0x400F2B0")]
		private const string m_none = "none";

		// Token: 0x0400F2B1 RID: 62129
		[Token(Token = "0x400F2B1")]
		private const string m_enthusiasitc = "enthusiastic";

		// Token: 0x0400F2B2 RID: 62130
		[Token(Token = "0x400F2B2")]
		private const string m_depressed = "depressed";

		// Token: 0x0400F2B3 RID: 62131
		[Token(Token = "0x400F2B3")]
		private const string m_durationAudioBuffStr = "duration_audio_buff";

		// Token: 0x0400F2B4 RID: 62132
		[Token(Token = "0x400F2B4")]
		private const string m_durationBossAudioBuffStr = "duration_boss_audio_buff";

		// Token: 0x0400F2B5 RID: 62133
		[Token(Token = "0x400F2B5")]
		private const string m_durationPortalActiveStr = "duration_portal_active";

		// Token: 0x0400F2B6 RID: 62134
		[Token(Token = "0x400F2B6")]
		private const string m_portalTrapActiveBuffName = "trap_portlexi[active]";

		// Token: 0x0400F2B7 RID: 62135
		[Token(Token = "0x400F2B7")]
		private const string m_portlexiId = "trap_136_portlexi";

		// Token: 0x0400F2B8 RID: 62136
		[Token(Token = "0x400F2B8")]
		private const string m_playExtraAudioStr = "play_extra_music";

		// Token: 0x0400F2B9 RID: 62137
		[Token(Token = "0x400F2B9")]
		[FieldOffset(Offset = "0x40")]
		private PeriodicTimer m_switchTimer;

		// Token: 0x0400F2BA RID: 62138
		[Token(Token = "0x400F2BA")]
		[FieldOffset(Offset = "0x48")]
		private PeriodicTimer m_audioBuffDurationTimer;

		// Token: 0x0400F2BB RID: 62139
		[Token(Token = "0x400F2BB")]
		[FieldOffset(Offset = "0x50")]
		private PeriodicTimer m_portalTrapActiveTimer;

		// Token: 0x0400F2BC RID: 62140
		[Token(Token = "0x400F2BC")]
		[FieldOffset(Offset = "0x58")]
		private PeriodicTimer m_audioBuffDurationTimer_bossCtrl;

		// Token: 0x0400F2BD RID: 62141
		[Token(Token = "0x400F2BD")]
		[FieldOffset(Offset = "0x60")]
		private List<float> m_switchIntervalList;

		// Token: 0x0400F2BE RID: 62142
		[Token(Token = "0x400F2BE")]
		[FieldOffset(Offset = "0x68")]
		private List<Act29SideManager.AudioType> m_switchSideList;

		// Token: 0x0400F2BF RID: 62143
		[Token(Token = "0x400F2BF")]
		[FieldOffset(Offset = "0x70")]
		private int m_currentStage;

		// Token: 0x0400F2C0 RID: 62144
		[Token(Token = "0x400F2C0")]
		[FieldOffset(Offset = "0x74")]
		private Act29SideManager.AudioType m_currentAudioType;

		// Token: 0x0400F2C1 RID: 62145
		[Token(Token = "0x400F2C1")]
		[FieldOffset(Offset = "0x78")]
		private List<float> m_durationAudioBuff;

		// Token: 0x0400F2C2 RID: 62146
		[Token(Token = "0x400F2C2")]
		[FieldOffset(Offset = "0x80")]
		private float m_durationPortalActive;

		// Token: 0x0400F2C3 RID: 62147
		[Token(Token = "0x400F2C3")]
		[FieldOffset(Offset = "0x84")]
		private float m_durationBossAudioBuff;

		// Token: 0x0400F2C4 RID: 62148
		[Token(Token = "0x400F2C4")]
		[FieldOffset(Offset = "0x88")]
		private List<Trap> m_portalTraps;

		// Token: 0x0400F2C5 RID: 62149
		[Token(Token = "0x400F2C5")]
		[FieldOffset(Offset = "0x90")]
		private int m_currentActivePortalTrapIndex;

		// Token: 0x0400F2C6 RID: 62150
		[Token(Token = "0x400F2C6")]
		[FieldOffset(Offset = "0x94")]
		private bool m_uiSignalTriggeredSkillManually;

		// Token: 0x0400F2C7 RID: 62151
		[Token(Token = "0x400F2C7")]
		[FieldOffset(Offset = "0x95")]
		private bool m_isControlledByBoss;

		// Token: 0x0400F2C8 RID: 62152
		[Token(Token = "0x400F2C8")]
		[FieldOffset(Offset = "0x96")]
		private bool m_isBossDead;

		// Token: 0x0400F2C9 RID: 62153
		[Token(Token = "0x400F2C9")]
		[FieldOffset(Offset = "0x98")]
		private Act29SideManager.AudioType m_lastAudioType;

		// Token: 0x0400F2CA RID: 62154
		[Token(Token = "0x400F2CA")]
		[FieldOffset(Offset = "0x9C")]
		private Act29SideManager.AudioType m_lastAudioTypeNormal;

		// Token: 0x0400F2CB RID: 62155
		[Token(Token = "0x400F2CB")]
		[FieldOffset(Offset = "0xA0")]
		private CameraEffect m_enthEff;

		// Token: 0x0400F2CC RID: 62156
		[Token(Token = "0x400F2CC")]
		[FieldOffset(Offset = "0xA8")]
		private CameraEffect m_depEff;

		// Token: 0x0400F2CD RID: 62157
		[Token(Token = "0x400F2CD")]
		[FieldOffset(Offset = "0xB0")]
		private Act29SideManager.Act29sideAudioController m_audioController;

		// Token: 0x0400F2CE RID: 62158
		[Token(Token = "0x400F2CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F2CF RID: 62159
		[Token(Token = "0x400F2CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentAudioType;

		// Token: 0x0400F2D0 RID: 62160
		[Token(Token = "0x400F2D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_audioBuffRamainingTime;

		// Token: 0x0400F2D1 RID: 62161
		[Token(Token = "0x400F2D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_audioTypeRamainingTime;

		// Token: 0x0400F2D2 RID: 62162
		[Token(Token = "0x400F2D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_currentStage;

		// Token: 0x0400F2D3 RID: 62163
		[Token(Token = "0x400F2D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isControlledByBoss;

		// Token: 0x0400F2D4 RID: 62164
		[Token(Token = "0x400F2D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_switchIntervalList;

		// Token: 0x0400F2D5 RID: 62165
		[Token(Token = "0x400F2D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_durationAudioBuff;

		// Token: 0x0400F2D6 RID: 62166
		[Token(Token = "0x400F2D6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_switchSideList;

		// Token: 0x0400F2D7 RID: 62167
		[Token(Token = "0x400F2D7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_uiSignalTriggeredSkillManually;

		// Token: 0x0400F2D8 RID: 62168
		[Token(Token = "0x400F2D8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_uiSignalTriggeredSkillManually;

		// Token: 0x0400F2D9 RID: 62169
		[Token(Token = "0x400F2D9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isBossDead;

		// Token: 0x0400F2DA RID: 62170
		[Token(Token = "0x400F2DA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_bossAudioBuffTime;

		// Token: 0x0400F2DB RID: 62171
		[Token(Token = "0x400F2DB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_bossAudioBuffProgress;

		// Token: 0x0400F2DC RID: 62172
		[Token(Token = "0x400F2DC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F2DD RID: 62173
		[Token(Token = "0x400F2DD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F2DE RID: 62174
		[Token(Token = "0x400F2DE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400F2DF RID: 62175
		[Token(Token = "0x400F2DF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RegisterPortalTraps;

		// Token: 0x0400F2E0 RID: 62176
		[Token(Token = "0x400F2E0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SwitchAudioTypeManually;

		// Token: 0x0400F2E1 RID: 62177
		[Token(Token = "0x400F2E1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SwitchAudioByBoss;

		// Token: 0x0400F2E2 RID: 62178
		[Token(Token = "0x400F2E2")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_MuteAll;

		// Token: 0x0400F2E3 RID: 62179
		[Token(Token = "0x400F2E3")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400F2E4 RID: 62180
		[Token(Token = "0x400F2E4")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F2E5 RID: 62181
		[Token(Token = "0x400F2E5")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400F2E6 RID: 62182
		[Token(Token = "0x400F2E6")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400F2E7 RID: 62183
		[Token(Token = "0x400F2E7")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__ProcessBlackboard;

		// Token: 0x0400F2E8 RID: 62184
		[Token(Token = "0x400F2E8")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__NextSwitchSide;

		// Token: 0x0400F2E9 RID: 62185
		[Token(Token = "0x400F2E9")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ResetSwitchTimer;

		// Token: 0x0400F2EA RID: 62186
		[Token(Token = "0x400F2EA")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ResetAudioBuffDurationTimer;

		// Token: 0x0400F2EB RID: 62187
		[Token(Token = "0x400F2EB")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ActiveProperPortalTrap;

		// Token: 0x0400F2EC RID: 62188
		[Token(Token = "0x400F2EC")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022B9 RID: 8889
		[Token(Token = "0x20022B9")]
		public enum AudioType
		{
			// Token: 0x0400F2EE RID: 62190
			[Token(Token = "0x400F2EE")]
			None,
			// Token: 0x0400F2EF RID: 62191
			[Token(Token = "0x400F2EF")]
			Enthusiastic,
			// Token: 0x0400F2F0 RID: 62192
			[Token(Token = "0x400F2F0")]
			Depressed
		}

		// Token: 0x020022BA RID: 8890
		[Token(Token = "0x20022BA")]
		private class Act29sideAudioController : IBattleBGMModule, IHotfixable, IDisposable
		{
			// Token: 0x17001C12 RID: 7186
			// (get) Token: 0x0600DF8B RID: 57227 RVA: 0x00051378 File Offset: 0x0004F578
			// (set) Token: 0x0600DF8C RID: 57228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C12")]
			public bool isValid
			{
				[Token(Token = "0x600DF8B")]
				[Address(RVA = "0x364A230", Offset = "0x3648E30", VA = "0x18364A230")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600DF8C")]
				[Address(RVA = "0x364A2F0", Offset = "0x3648EF0", VA = "0x18364A2F0")]
				set
				{
				}
			}

			// Token: 0x17001C13 RID: 7187
			// (get) Token: 0x0600DF8D RID: 57229 RVA: 0x00051390 File Offset: 0x0004F590
			[Token(Token = "0x17001C13")]
			public BattleBGMLevel level
			{
				[Token(Token = "0x600DF8D")]
				[Address(RVA = "0x364A290", Offset = "0x3648E90", VA = "0x18364A290", Slot = "4")]
				get
				{
					return BattleBGMLevel.CHARACTER_FEVER;
				}
			}

			// Token: 0x0600DF8E RID: 57230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF8E")]
			[Address(RVA = "0x3649630", Offset = "0x3648230", VA = "0x183649630")]
			public void Init(Blackboard blackboard)
			{
			}

			// Token: 0x0600DF8F RID: 57231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF8F")]
			[Address(RVA = "0x3649E10", Offset = "0x3648A10", VA = "0x183649E10")]
			public void PlayAudio(Act29SideManager.AudioType type)
			{
			}

			// Token: 0x0600DF90 RID: 57232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF90")]
			[Address(RVA = "0x36499A0", Offset = "0x36485A0", VA = "0x1836499A0")]
			public void MuteAllExtraAudio(bool isStoppedByModule = false)
			{
			}

			// Token: 0x0600DF91 RID: 57233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF91")]
			[Address(RVA = "0x3649BB0", Offset = "0x36487B0", VA = "0x183649BB0", Slot = "5")]
			public void OnMute(BattleBGMManager.BattleBGMInfo bgmInfo)
			{
			}

			// Token: 0x0600DF92 RID: 57234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF92")]
			[Address(RVA = "0x3649D70", Offset = "0x3648970", VA = "0x183649D70", Slot = "6")]
			public void OnResume(BattleBGMManager.BattleBGMInfo bgmInfo)
			{
			}

			// Token: 0x0600DF93 RID: 57235 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF93")]
			[Address(RVA = "0x3649B30", Offset = "0x3648730", VA = "0x183649B30", Slot = "7")]
			public void OnInterrupt(BattleBGMManager.BattleBGMInfo bgmInfo)
			{
			}

			// Token: 0x0600DF94 RID: 57236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF94")]
			[Address(RVA = "0x36495B0", Offset = "0x36481B0", VA = "0x1836495B0", Slot = "8")]
			public void Dispose()
			{
			}

			// Token: 0x0600DF95 RID: 57237 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DF95")]
			[Address(RVA = "0x364A160", Offset = "0x3648D60", VA = "0x18364A160")]
			public Act29sideAudioController()
			{
			}

			// Token: 0x0400F2F1 RID: 62193
			[Token(Token = "0x400F2F1")]
			private const int EXPECTED_BANK_NUM = 3;

			// Token: 0x0400F2F2 RID: 62194
			[Token(Token = "0x400F2F2")]
			private const int NORMAL_BANK_ID = 0;

			// Token: 0x0400F2F3 RID: 62195
			[Token(Token = "0x400F2F3")]
			private const int DEPRESSED_BANK_ID = 1;

			// Token: 0x0400F2F4 RID: 62196
			[Token(Token = "0x400F2F4")]
			private const int ENTHU_BANK_ID = 2;

			// Token: 0x0400F2F5 RID: 62197
			[Token(Token = "0x400F2F5")]
			[FieldOffset(Offset = "0x10")]
			private string m_normalBankName;

			// Token: 0x0400F2F6 RID: 62198
			[Token(Token = "0x400F2F6")]
			[FieldOffset(Offset = "0x18")]
			private string m_depressedBankName;

			// Token: 0x0400F2F7 RID: 62199
			[Token(Token = "0x400F2F7")]
			[FieldOffset(Offset = "0x20")]
			private string m_enthuBankName;

			// Token: 0x0400F2F8 RID: 62200
			[Token(Token = "0x400F2F8")]
			[FieldOffset(Offset = "0x28")]
			private bool m_playExtraMusic;

			// Token: 0x0400F2F9 RID: 62201
			[Token(Token = "0x400F2F9")]
			[FieldOffset(Offset = "0x30")]
			private UIMusicDuckingHelper m_depressedDuckingHelper;

			// Token: 0x0400F2FA RID: 62202
			[Token(Token = "0x400F2FA")]
			[FieldOffset(Offset = "0x38")]
			private UIMusicDuckingHelper m_enthuDuckingHelper;

			// Token: 0x0400F2FB RID: 62203
			[Token(Token = "0x400F2FB")]
			[FieldOffset(Offset = "0x40")]
			private AudioMusicGroupHandler m_depressedMusicGroupHandler;

			// Token: 0x0400F2FC RID: 62204
			[Token(Token = "0x400F2FC")]
			[FieldOffset(Offset = "0x48")]
			private AudioMusicGroupHandler m_enthuMusicGroupHandler;

			// Token: 0x0400F2FD RID: 62205
			[Token(Token = "0x400F2FD")]
			[FieldOffset(Offset = "0x50")]
			private Act29SideManager.AudioType m_currentAudioType;

			// Token: 0x0400F2FE RID: 62206
			[Token(Token = "0x400F2FE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isValid;

			// Token: 0x0400F2FF RID: 62207
			[Token(Token = "0x400F2FF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isValid;

			// Token: 0x0400F300 RID: 62208
			[Token(Token = "0x400F300")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_level;

			// Token: 0x0400F301 RID: 62209
			[Token(Token = "0x400F301")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Init;

			// Token: 0x0400F302 RID: 62210
			[Token(Token = "0x400F302")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_PlayAudio;

			// Token: 0x0400F303 RID: 62211
			[Token(Token = "0x400F303")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_MuteAllExtraAudio;

			// Token: 0x0400F304 RID: 62212
			[Token(Token = "0x400F304")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_OnMute;

			// Token: 0x0400F305 RID: 62213
			[Token(Token = "0x400F305")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_OnResume;

			// Token: 0x0400F306 RID: 62214
			[Token(Token = "0x400F306")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_OnInterrupt;

			// Token: 0x0400F307 RID: 62215
			[Token(Token = "0x400F307")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x0400F308 RID: 62216
			[Token(Token = "0x400F308")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
