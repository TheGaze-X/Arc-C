using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B41 RID: 11073
	[Token(Token = "0x2002B41")]
	public class EnergyBuffAbility : EmptyAbility
	{
		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x0601293A RID: 76090 RVA: 0x00071C70 File Offset: 0x0006FE70
		// (set) Token: 0x0601293B RID: 76091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170028F0")]
		public int maxEnergy
		{
			[Token(Token = "0x601293A")]
			[Address(RVA = "0xA83920", Offset = "0xA82520", VA = "0x180A83920")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601293B")]
			[Address(RVA = "0xA83A60", Offset = "0xA82660", VA = "0x180A83A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170028F1 RID: 10481
		// (get) Token: 0x0601293C RID: 76092 RVA: 0x00071C88 File Offset: 0x0006FE88
		[Token(Token = "0x170028F1")]
		public int energyCnt
		{
			[Token(Token = "0x601293C")]
			[Address(RVA = "0xA83870", Offset = "0xA82470", VA = "0x180A83870")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170028F2 RID: 10482
		// (get) Token: 0x0601293D RID: 76093 RVA: 0x00071CA0 File Offset: 0x0006FEA0
		[Token(Token = "0x170028F2")]
		public bool overEnergyIsCasting
		{
			[Token(Token = "0x601293D")]
			[Address(RVA = "0xA83980", Offset = "0xA82580", VA = "0x180A83980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170028F3 RID: 10483
		// (get) Token: 0x0601293E RID: 76094 RVA: 0x00071CB8 File Offset: 0x0006FEB8
		[Token(Token = "0x170028F3")]
		public FP castProgress
		{
			[Token(Token = "0x601293E")]
			[Address(RVA = "0xA83740", Offset = "0xA82340", VA = "0x180A83740")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0601293F RID: 76095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601293F")]
		[Address(RVA = "0xA82C80", Offset = "0xA81880", VA = "0x180A82C80", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012940 RID: 76096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012940")]
		[Address(RVA = "0xA82B00", Offset = "0xA81700", VA = "0x180A82B00", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012941 RID: 76097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012941")]
		[Address(RVA = "0xA82A30", Offset = "0xA81630", VA = "0x180A82A30", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012942 RID: 76098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012942")]
		[Address(RVA = "0xA82D20", Offset = "0xA81920", VA = "0x180A82D20", Slot = "31")]
		public override void OnOwnerLocated()
		{
		}

		// Token: 0x06012943 RID: 76099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012943")]
		[Address(RVA = "0xA834C0", Offset = "0xA820C0", VA = "0x180A834C0")]
		private void _InitEnergy()
		{
		}

		// Token: 0x06012944 RID: 76100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012944")]
		[Address(RVA = "0xA83420", Offset = "0xA82020", VA = "0x180A83420")]
		private void _ClearEnergy()
		{
		}

		// Token: 0x06012945 RID: 76101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012945")]
		[Address(RVA = "0xA82F10", Offset = "0xA81B10", VA = "0x180A82F10")]
		public void UpdateEnergy()
		{
		}

		// Token: 0x06012946 RID: 76102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012946")]
		[Address(RVA = "0xA83660", Offset = "0xA82260", VA = "0x180A83660")]
		public EnergyBuffAbility()
		{
		}

		// Token: 0x06012947 RID: 76103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012947")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x06012948 RID: 76104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012948")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012949 RID: 76105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012949")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x0601294A RID: 76106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601294A")]
		[Address(RVA = "0xA82F00", Offset = "0xA81B00", VA = "0x180A82F00")]
		private void <>xLuaBaseProxy_OnOwnerLocated()
		{
		}

		// Token: 0x04014FCA RID: 85962
		[Token(Token = "0x4014FCA")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		protected BuffData _buff;

		// Token: 0x04014FCB RID: 85963
		[Token(Token = "0x4014FCB")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected bool _overEnergied;

		// Token: 0x04014FCC RID: 85964
		[Token(Token = "0x4014FCC")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private string _castAbility;

		// Token: 0x04014FCD RID: 85965
		[Token(Token = "0x4014FCD")]
		[FieldOffset(Offset = "0x128")]
		private ObjectPtr<Buff> m_buff;

		// Token: 0x04014FCE RID: 85966
		[Token(Token = "0x4014FCE")]
		[FieldOffset(Offset = "0x138")]
		private Ability m_castAbility;

		// Token: 0x04014FD0 RID: 85968
		[Token(Token = "0x4014FD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxEnergy;

		// Token: 0x04014FD1 RID: 85969
		[Token(Token = "0x4014FD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_maxEnergy;

		// Token: 0x04014FD2 RID: 85970
		[Token(Token = "0x4014FD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_energyCnt;

		// Token: 0x04014FD3 RID: 85971
		[Token(Token = "0x4014FD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_overEnergyIsCasting;

		// Token: 0x04014FD4 RID: 85972
		[Token(Token = "0x4014FD4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_castProgress;

		// Token: 0x04014FD5 RID: 85973
		[Token(Token = "0x4014FD5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014FD6 RID: 85974
		[Token(Token = "0x4014FD6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014FD7 RID: 85975
		[Token(Token = "0x4014FD7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014FD8 RID: 85976
		[Token(Token = "0x4014FD8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnOwnerLocated;

		// Token: 0x04014FD9 RID: 85977
		[Token(Token = "0x4014FD9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitEnergy;

		// Token: 0x04014FDA RID: 85978
		[Token(Token = "0x4014FDA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearEnergy;

		// Token: 0x04014FDB RID: 85979
		[Token(Token = "0x4014FDB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UpdateEnergy;

		// Token: 0x04014FDC RID: 85980
		[Token(Token = "0x4014FDC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
