using System;
using Il2CppDummyDll;
using Torappu.UI.HotUpdate;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003492 RID: 13458
	[Token(Token = "0x2003492")]
	[CreateAssetMenu(menuName = "Torappu/Options/BasicUIOptions")]
	public class BasicUIOptions : SingletonScriptableObject<BasicUIOptions>
	{
		// Token: 0x170032A4 RID: 12964
		// (get) Token: 0x0601574D RID: 87885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170032A4")]
		public HotUpdateVoicePackView hotUpdateVoicePref
		{
			[Token(Token = "0x601574D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601574E RID: 87886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601574E")]
		[Address(RVA = "0xDE6740", Offset = "0xDE5340", VA = "0x180DE6740")]
		public BasicUIOptions()
		{
		}

		// Token: 0x04019AFB RID: 105211
		[Token(Token = "0x4019AFB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HotUpdateVoicePackView _hotUpdateVoicePref;
	}
}
