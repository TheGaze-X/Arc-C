using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200526C RID: 21100
	[Token(Token = "0x200526C")]
	public abstract class RoguelikeMainTransController : MonoBehaviour, IHotfixable
	{
		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x0601F23A RID: 127546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048F9")]
		public RoguelikeSubTransitionPluginContext pluginContextPrefab
		{
			[Token(Token = "0x601F23A")]
			[Address(RVA = "0x18ED8A0", Offset = "0x18EC4A0", VA = "0x1818ED8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F23B RID: 127547
		[Token(Token = "0x601F23B")]
		public abstract void Render(RoguelikeDungeonZoneViewProperty property);

		// Token: 0x0601F23C RID: 127548
		[Token(Token = "0x601F23C")]
		public abstract void Reset();

		// Token: 0x0601F23D RID: 127549
		[Token(Token = "0x601F23D")]
		public abstract IEnumerator TransCoroutine();

		// Token: 0x0601F23E RID: 127550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F23E")]
		[Address(RVA = "0x18ED840", Offset = "0x18EC440", VA = "0x1818ED840")]
		protected RoguelikeMainTransController()
		{
		}

		// Token: 0x04029C93 RID: 171155
		[Token(Token = "0x4029C93")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeSubTransitionPluginContext _pluginContextPrefab;

		// Token: 0x04029C94 RID: 171156
		[Token(Token = "0x4029C94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pluginContextPrefab;

		// Token: 0x04029C95 RID: 171157
		[Token(Token = "0x4029C95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200526D RID: 21101
		[Token(Token = "0x200526D")]
		protected struct MainTransParam : IHotfixable
		{
			// Token: 0x0601F23F RID: 127551 RVA: 0x000B0FE8 File Offset: 0x000AF1E8
			[Token(Token = "0x601F23F")]
			[Address(RVA = "0x18DE550", Offset = "0x18DD150", VA = "0x1818DE550")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0601F240 RID: 127552 RVA: 0x000B1000 File Offset: 0x000AF200
			[Token(Token = "0x601F240")]
			[Address(RVA = "0x18DE220", Offset = "0x18DCE20", VA = "0x1818DE220")]
			public static RoguelikeMainTransController.MainTransParam Create(RoguelikeDungeonZoneViewModel zoneModel, ShallowEqualArray<string> reusableIdList)
			{
				return default(RoguelikeMainTransController.MainTransParam);
			}

			// Token: 0x04029C96 RID: 171158
			[Token(Token = "0x4029C96")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x04029C97 RID: 171159
			[Token(Token = "0x4029C97")]
			[FieldOffset(Offset = "0x8")]
			public bool isVariation;

			// Token: 0x04029C98 RID: 171160
			[Token(Token = "0x4029C98")]
			[FieldOffset(Offset = "0x9")]
			public bool isAutoTrans;

			// Token: 0x04029C99 RID: 171161
			[Token(Token = "0x4029C99")]
			[FieldOffset(Offset = "0xA")]
			public bool isManualTrans;

			// Token: 0x04029C9A RID: 171162
			[Token(Token = "0x4029C9A")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeGameZoneData zoneData;

			// Token: 0x04029C9B RID: 171163
			[Token(Token = "0x4029C9B")]
			[FieldOffset(Offset = "0x18")]
			public ShallowEqualArray<string> variationIdList;

			// Token: 0x04029C9C RID: 171164
			[Token(Token = "0x4029C9C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x04029C9D RID: 171165
			[Token(Token = "0x4029C9D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Create;
		}
	}
}
