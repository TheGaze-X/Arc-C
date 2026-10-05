using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033C3 RID: 13251
	[Token(Token = "0x20033C3")]
	public class UIBattleSandboxNotificationItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x06015246 RID: 86598 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06015247 RID: 86599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700322E")]
		public UIBattleSandboxItemNotification parent
		{
			[Token(Token = "0x6015246")]
			[Address(RVA = "0xD93D60", Offset = "0xD92960", VA = "0x180D93D60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6015247")]
			[Address(RVA = "0xD93E70", Offset = "0xD92A70", VA = "0x180D93E70")]
			set
			{
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x06015248 RID: 86600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700322F")]
		private GameModeFactory.SandboxGameMode sandboxGameMode
		{
			[Token(Token = "0x6015248")]
			[Address(RVA = "0xD93DC0", Offset = "0xD929C0", VA = "0x180D93DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015249 RID: 86601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015249")]
		[Address(RVA = "0xD92F50", Offset = "0xD91B50", VA = "0x180D92F50")]
		private void Awake()
		{
		}

		// Token: 0x0601524A RID: 86602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601524A")]
		[Address(RVA = "0xD92FD0", Offset = "0xD91BD0", VA = "0x180D92FD0")]
		[Inspect]
		public void BeginTweens()
		{
		}

		// Token: 0x0601524B RID: 86603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601524B")]
		[Address(RVA = "0xD93260", Offset = "0xD91E60", VA = "0x180D93260")]
		[Inspect]
		public void EndTweens()
		{
		}

		// Token: 0x0601524C RID: 86604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601524C")]
		[Address(RVA = "0xD93A50", Offset = "0xD92650", VA = "0x180D93A50")]
		private void _OnBeginMoveTweenComplete()
		{
		}

		// Token: 0x0601524D RID: 86605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601524D")]
		[Address(RVA = "0xD938F0", Offset = "0xD924F0", VA = "0x180D938F0")]
		private IEnumerator _ItemLife()
		{
			return null;
		}

		// Token: 0x0601524E RID: 86606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601524E")]
		[Address(RVA = "0xD93B80", Offset = "0xD92780", VA = "0x180D93B80")]
		private void _OnEndMoveTweenComplete()
		{
		}

		// Token: 0x0601524F RID: 86607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601524F")]
		[Address(RVA = "0xD934F0", Offset = "0xD920F0", VA = "0x180D934F0")]
		public void Init()
		{
		}

		// Token: 0x06015250 RID: 86608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015250")]
		[Address(RVA = "0xD93630", Offset = "0xD92230", VA = "0x180D93630")]
		public void SetData(string itemId, int count)
		{
		}

		// Token: 0x06015251 RID: 86609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015251")]
		[Address(RVA = "0xD939A0", Offset = "0xD925A0", VA = "0x180D939A0")]
		private Sprite _LoadBackpackItemIcon(string itemId)
		{
			return null;
		}

		// Token: 0x06015252 RID: 86610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015252")]
		[Address(RVA = "0xD935A0", Offset = "0xD921A0", VA = "0x180D935A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06015253 RID: 86611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015253")]
		[Address(RVA = "0xD93CE0", Offset = "0xD928E0", VA = "0x180D93CE0")]
		public UIBattleSandboxNotificationItem()
		{
		}

		// Token: 0x04019366 RID: 103270
		[Token(Token = "0x4019366")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x04019367 RID: 103271
		[Token(Token = "0x4019367")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rarityRing;

		// Token: 0x04019368 RID: 103272
		[Token(Token = "0x4019368")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _addOnText;

		// Token: 0x04019369 RID: 103273
		[Token(Token = "0x4019369")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0401936A RID: 103274
		[Token(Token = "0x401936A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 _upOffset;

		// Token: 0x0401936B RID: 103275
		[Token(Token = "0x401936B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _downOffset;

		// Token: 0x0401936C RID: 103276
		[Token(Token = "0x401936C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _tweenTime;

		// Token: 0x0401936D RID: 103277
		[Token(Token = "0x401936D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _lifeTime;

		// Token: 0x0401936E RID: 103278
		[Token(Token = "0x401936E")]
		[FieldOffset(Offset = "0x50")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0401936F RID: 103279
		[Token(Token = "0x401936F")]
		[FieldOffset(Offset = "0x58")]
		private UIBattleSandboxItemNotification m_parent;

		// Token: 0x04019370 RID: 103280
		[Token(Token = "0x4019370")]
		[FieldOffset(Offset = "0x60")]
		private int m_itemRarity;

		// Token: 0x04019371 RID: 103281
		[Token(Token = "0x4019371")]
		[FieldOffset(Offset = "0x68")]
		private AutoPackSpriteHub m_itemIconSpriteHub;

		// Token: 0x04019372 RID: 103282
		[Token(Token = "0x4019372")]
		[FieldOffset(Offset = "0x70")]
		private GameModeFactory.SandboxGameMode m_gameMode;

		// Token: 0x04019373 RID: 103283
		[Token(Token = "0x4019373")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine m_tweenCoroutine;

		// Token: 0x04019374 RID: 103284
		[Token(Token = "0x4019374")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_parent;

		// Token: 0x04019375 RID: 103285
		[Token(Token = "0x4019375")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_parent;

		// Token: 0x04019376 RID: 103286
		[Token(Token = "0x4019376")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sandboxGameMode;

		// Token: 0x04019377 RID: 103287
		[Token(Token = "0x4019377")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04019378 RID: 103288
		[Token(Token = "0x4019378")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BeginTweens;

		// Token: 0x04019379 RID: 103289
		[Token(Token = "0x4019379")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EndTweens;

		// Token: 0x0401937A RID: 103290
		[Token(Token = "0x401937A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBeginMoveTweenComplete;

		// Token: 0x0401937B RID: 103291
		[Token(Token = "0x401937B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ItemLife;

		// Token: 0x0401937C RID: 103292
		[Token(Token = "0x401937C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnEndMoveTweenComplete;

		// Token: 0x0401937D RID: 103293
		[Token(Token = "0x401937D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401937E RID: 103294
		[Token(Token = "0x401937E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401937F RID: 103295
		[Token(Token = "0x401937F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadBackpackItemIcon;

		// Token: 0x04019380 RID: 103296
		[Token(Token = "0x4019380")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04019381 RID: 103297
		[Token(Token = "0x4019381")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
