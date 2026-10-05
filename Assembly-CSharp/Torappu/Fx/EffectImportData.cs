using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Torappu.Fx
{
	// Token: 0x0200203F RID: 8255
	[Token(Token = "0x200203F")]
	public class EffectImportData : MonoBehaviour
	{
		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x0600CB6A RID: 52074 RVA: 0x000498A8 File Offset: 0x00047AA8
		[Token(Token = "0x1700181B")]
		public bool removeTopAnimator
		{
			[Token(Token = "0x600CB6A")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x000498C0 File Offset: 0x00047AC0
		[Token(Token = "0x1700181C")]
		public bool isUIEffect
		{
			[Token(Token = "0x600CB6B")]
			[Address(RVA = "0x34BF5E0", Offset = "0x34BE1E0", VA = "0x1834BF5E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x0600CB6C RID: 52076 RVA: 0x000498D8 File Offset: 0x00047AD8
		[Token(Token = "0x1700181D")]
		public bool convertFxDelayToDelayToStart
		{
			[Token(Token = "0x600CB6C")]
			[Address(RVA = "0x106F290", Offset = "0x106DE90", VA = "0x18106F290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x0600CB6D RID: 52077 RVA: 0x000498F0 File Offset: 0x00047AF0
		[Token(Token = "0x1700181E")]
		public Vector3 advancedPositionToStaticOffset
		{
			[Token(Token = "0x600CB6D")]
			[Address(RVA = "0x34BF5A0", Offset = "0x34BE1A0", VA = "0x1834BF5A0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x0600CB6E RID: 52078 RVA: 0x00049908 File Offset: 0x00047B08
		[Token(Token = "0x1700181F")]
		public Vector3 advancedRotationToStaticOffset
		{
			[Token(Token = "0x600CB6E")]
			[Address(RVA = "0x34BF5C0", Offset = "0x34BE1C0", VA = "0x1834BF5C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600CB6F RID: 52079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CB6F")]
		[Address(RVA = "0x34BF490", Offset = "0x34BE090", VA = "0x1834BF490")]
		public string GetImportName()
		{
			return null;
		}

		// Token: 0x0600CB70 RID: 52080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CB70")]
		[Address(RVA = "0x34BF4D0", Offset = "0x34BE0D0", VA = "0x1834BF4D0")]
		public string GetResourceName()
		{
			return null;
		}

		// Token: 0x0600CB71 RID: 52081 RVA: 0x00049920 File Offset: 0x00047B20
		[Token(Token = "0x600CB71")]
		[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
		public int GetSortingLayerID()
		{
			return 0;
		}

		// Token: 0x0600CB72 RID: 52082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB72")]
		[Address(RVA = "0x34BF510", Offset = "0x34BE110", VA = "0x1834BF510")]
		public EffectImportData()
		{
		}

		// Token: 0x0400D5A6 RID: 54694
		[Token(Token = "0x400D5A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("_overwriteName")]
		private string _importName;

		// Token: 0x0400D5A7 RID: 54695
		[Token(Token = "0x400D5A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _resourceName;

		// Token: 0x0400D5A8 RID: 54696
		[Token(Token = "0x400D5A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SortingLayerWrapper _sortingLayerId;

		// Token: 0x0400D5A9 RID: 54697
		[Token(Token = "0x400D5A9")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _removeTopAnimator;

		// Token: 0x0400D5AA RID: 54698
		[Token(Token = "0x400D5AA")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		private bool _convertFxDelayToDelayToStart;

		// Token: 0x0400D5AB RID: 54699
		[Token(Token = "0x400D5AB")]
		[FieldOffset(Offset = "0x2E")]
		[SerializeField]
		private bool _isUIEffect;

		// Token: 0x0400D5AC RID: 54700
		[Token(Token = "0x400D5AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector3 _advancedPositionToStaticOffset;

		// Token: 0x0400D5AD RID: 54701
		[Token(Token = "0x400D5AD")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 _advancedRotationToStaticOffset;
	}
}
