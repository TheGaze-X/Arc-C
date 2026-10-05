using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021F1 RID: 8689
	[Token(Token = "0x20021F1")]
	public class ParticleEffectManager : SingletonMonoBehaviour<ParticleEffectManager>, ILuaCallCSharp
	{
		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x0600D95F RID: 55647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001AD4")]
		private ParticleEffectManagerConfig config
		{
			[Token(Token = "0x600D95F")]
			[Address(RVA = "0x35E68A0", Offset = "0x35E54A0", VA = "0x1835E68A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D960 RID: 55648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D960")]
		[Address(RVA = "0x35E5950", Offset = "0x35E4550", VA = "0x1835E5950", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600D961 RID: 55649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D961")]
		[Address(RVA = "0x35E58F0", Offset = "0x35E44F0", VA = "0x1835E58F0")]
		public void CreateInstance()
		{
		}

		// Token: 0x0600D962 RID: 55650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D962")]
		[Address(RVA = "0x35E5C30", Offset = "0x35E4830", VA = "0x1835E5C30")]
		public void RegisterParticleEffect(ParticleEffect particleEffect)
		{
		}

		// Token: 0x0600D963 RID: 55651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D963")]
		[Address(RVA = "0x35E5E40", Offset = "0x35E4A40", VA = "0x1835E5E40")]
		public void UnregisterParticleEffect(ParticleEffect particleEffect)
		{
		}

		// Token: 0x0600D964 RID: 55652 RVA: 0x0004EF00 File Offset: 0x0004D100
		[Token(Token = "0x600D964")]
		[Address(RVA = "0x35E56B0", Offset = "0x35E42B0", VA = "0x1835E56B0")]
		public bool CheckEffectByPos(ParticleEffect particleEffect)
		{
			return default(bool);
		}

		// Token: 0x0600D965 RID: 55653 RVA: 0x0004EF18 File Offset: 0x0004D118
		[Token(Token = "0x600D965")]
		[Address(RVA = "0x35E63D0", Offset = "0x35E4FD0", VA = "0x1835E63D0")]
		private int _GeneratePositionHash(Vector3 position)
		{
			return 0;
		}

		// Token: 0x0600D966 RID: 55654 RVA: 0x0004EF30 File Offset: 0x0004D130
		[Token(Token = "0x600D966")]
		[Address(RVA = "0x35E6190", Offset = "0x35E4D90", VA = "0x1835E6190")]
		private int _GenerateOffsetPositionHash(Vector3 position)
		{
			return 0;
		}

		// Token: 0x0600D967 RID: 55655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D967")]
		[Address(RVA = "0x35E5FC0", Offset = "0x35E4BC0", VA = "0x1835E5FC0")]
		private static void _AddToDict(Dictionary<int, Dictionary<string, int>> dict, int hash, string effectKey)
		{
		}

		// Token: 0x0600D968 RID: 55656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D968")]
		[Address(RVA = "0x35E6590", Offset = "0x35E5190", VA = "0x1835E6590")]
		private static void _RemoveFromDict(Dictionary<int, Dictionary<string, int>> dict, int hash, string effectKey)
		{
		}

		// Token: 0x0600D969 RID: 55657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D969")]
		[Address(RVA = "0x35E6750", Offset = "0x35E5350", VA = "0x1835E6750")]
		public ParticleEffectManager()
		{
		}

		// Token: 0x0400EA6B RID: 60011
		[Token(Token = "0x400EA6B")]
		private const int HASH_MULTIPLIER = 1000;

		// Token: 0x0400EA6C RID: 60012
		[Token(Token = "0x400EA6C")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<uint, Vector3> m_positionMap;

		// Token: 0x0400EA6D RID: 60013
		[Token(Token = "0x400EA6D")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, Dictionary<string, int>> m_positionCountMap;

		// Token: 0x0400EA6E RID: 60014
		[Token(Token = "0x400EA6E")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<int, Dictionary<string, int>> m_positionCountMap2;

		// Token: 0x0400EA6F RID: 60015
		[Token(Token = "0x400EA6F")]
		[FieldOffset(Offset = "0x30")]
		private ParticleEffectManagerConfig m_config;

		// Token: 0x0400EA70 RID: 60016
		[Token(Token = "0x400EA70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_config;

		// Token: 0x0400EA71 RID: 60017
		[Token(Token = "0x400EA71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400EA72 RID: 60018
		[Token(Token = "0x400EA72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateInstance;

		// Token: 0x0400EA73 RID: 60019
		[Token(Token = "0x400EA73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterParticleEffect;

		// Token: 0x0400EA74 RID: 60020
		[Token(Token = "0x400EA74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnregisterParticleEffect;

		// Token: 0x0400EA75 RID: 60021
		[Token(Token = "0x400EA75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckEffectByPos;

		// Token: 0x0400EA76 RID: 60022
		[Token(Token = "0x400EA76")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GeneratePositionHash;

		// Token: 0x0400EA77 RID: 60023
		[Token(Token = "0x400EA77")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateOffsetPositionHash;

		// Token: 0x0400EA78 RID: 60024
		[Token(Token = "0x400EA78")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddToDict;

		// Token: 0x0400EA79 RID: 60025
		[Token(Token = "0x400EA79")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RemoveFromDict;

		// Token: 0x0400EA7A RID: 60026
		[Token(Token = "0x400EA7A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
