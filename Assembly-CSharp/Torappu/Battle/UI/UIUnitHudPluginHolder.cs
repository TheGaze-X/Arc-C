using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200336C RID: 13164
	[Token(Token = "0x200336C")]
	public class UIUnitHudPluginHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0601500E RID: 86030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031E8")]
		public List<string> residentCharHuds
		{
			[Token(Token = "0x601500E")]
			[Address(RVA = "0xD7E680", Offset = "0xD7D280", VA = "0x180D7E680")]
			get
			{
				return null;
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0601500F RID: 86031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031E9")]
		public List<string> residentTrapHuds
		{
			[Token(Token = "0x601500F")]
			[Address(RVA = "0xD7E7A0", Offset = "0xD7D3A0", VA = "0x180D7E7A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x06015010 RID: 86032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031EA")]
		public List<string> residentEnemyHuds
		{
			[Token(Token = "0x6015010")]
			[Address(RVA = "0xD7E740", Offset = "0xD7D340", VA = "0x180D7E740")]
			get
			{
				return null;
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x06015011 RID: 86033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031EB")]
		public List<string> residentEnemyBossHuds
		{
			[Token(Token = "0x6015011")]
			[Address(RVA = "0xD7E6E0", Offset = "0xD7D2E0", VA = "0x180D7E6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x06015012 RID: 86034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170031EC")]
		public Dictionary<string, HudPluginMask> hudPluginMasks
		{
			[Token(Token = "0x6015012")]
			[Address(RVA = "0xD7E490", Offset = "0xD7D090", VA = "0x180D7E490")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015013 RID: 86035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015013")]
		[Address(RVA = "0xD7E200", Offset = "0xD7CE00", VA = "0x180D7E200")]
		public GameObject GetPlugin(string name)
		{
			return null;
		}

		// Token: 0x06015014 RID: 86036 RVA: 0x0008A0F0 File Offset: 0x000882F0
		[Token(Token = "0x6015014")]
		[Address(RVA = "0xD7E0C0", Offset = "0xD7CCC0", VA = "0x180D7E0C0")]
		public HudPluginMask GetMask(string name)
		{
			return HudPluginMask.NONE;
		}

		// Token: 0x06015015 RID: 86037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015015")]
		[Address(RVA = "0xD7E3E0", Offset = "0xD7CFE0", VA = "0x180D7E3E0")]
		public UIUnitHudPluginHolder()
		{
		}

		// Token: 0x04018FCC RID: 102348
		[Token(Token = "0x4018FCC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<UIUnitHudPluginHolder.HudMaskPair> _hudMaskPairs;

		// Token: 0x04018FCD RID: 102349
		[Token(Token = "0x4018FCD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _residentCharHuds;

		// Token: 0x04018FCE RID: 102350
		[Token(Token = "0x4018FCE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<string> _residentTrapHuds;

		// Token: 0x04018FCF RID: 102351
		[Token(Token = "0x4018FCF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<string> _residentEnemyHuds;

		// Token: 0x04018FD0 RID: 102352
		[Token(Token = "0x4018FD0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<string> _residentEnemyBossHuds;

		// Token: 0x04018FD1 RID: 102353
		[Token(Token = "0x4018FD1")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<string, HudPluginMask> m_hudPluginMasks;

		// Token: 0x04018FD2 RID: 102354
		[Token(Token = "0x4018FD2")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, GameObject> m_hudPlugins;

		// Token: 0x04018FD3 RID: 102355
		[Token(Token = "0x4018FD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_residentCharHuds;

		// Token: 0x04018FD4 RID: 102356
		[Token(Token = "0x4018FD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_residentTrapHuds;

		// Token: 0x04018FD5 RID: 102357
		[Token(Token = "0x4018FD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_residentEnemyHuds;

		// Token: 0x04018FD6 RID: 102358
		[Token(Token = "0x4018FD6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_residentEnemyBossHuds;

		// Token: 0x04018FD7 RID: 102359
		[Token(Token = "0x4018FD7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_hudPluginMasks;

		// Token: 0x04018FD8 RID: 102360
		[Token(Token = "0x4018FD8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlugin;

		// Token: 0x04018FD9 RID: 102361
		[Token(Token = "0x4018FD9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetMask;

		// Token: 0x04018FDA RID: 102362
		[Token(Token = "0x4018FDA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200336D RID: 13165
		[Token(Token = "0x200336D")]
		[Serializable]
		private class HudMaskPair
		{
			// Token: 0x06015016 RID: 86038 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6015016")]
			[Address(RVA = "0xD6ACE0", Offset = "0xD698E0", VA = "0x180D6ACE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06015017 RID: 86039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015017")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HudMaskPair()
			{
			}

			// Token: 0x04018FDB RID: 102363
			[Token(Token = "0x4018FDB")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04018FDC RID: 102364
			[Token(Token = "0x4018FDC")]
			[FieldOffset(Offset = "0x18")]
			public HudPluginMask mask;
		}
	}
}
