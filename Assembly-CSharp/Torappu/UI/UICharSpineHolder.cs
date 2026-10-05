using System;
using System.Collections;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Spine.Unity;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020037DB RID: 14299
	[Token(Token = "0x20037DB")]
	[RequireComponent(typeof(RectTransform))]
	public class UICharSpineHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x06016AC3 RID: 92867 RVA: 0x000925B0 File Offset: 0x000907B0
		[Token(Token = "0x17003639")]
		public bool loadOnStart
		{
			[Token(Token = "0x6016AC3")]
			[Address(RVA = "0xF0FBA0", Offset = "0xF0E7A0", VA = "0x180F0FBA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x06016AC4 RID: 92868 RVA: 0x000925C8 File Offset: 0x000907C8
		[Token(Token = "0x1700363A")]
		public bool isLoaded
		{
			[Token(Token = "0x6016AC4")]
			[Address(RVA = "0xF0FB10", Offset = "0xF0E710", VA = "0x180F0FB10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x06016AC5 RID: 92869 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016AC6 RID: 92870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700363B")]
		public string CharSkinId
		{
			[Token(Token = "0x6016AC5")]
			[Address(RVA = "0xF0FAB0", Offset = "0xF0E6B0", VA = "0x180F0FAB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6016AC6")]
			[Address(RVA = "0xF0FC00", Offset = "0xF0E800", VA = "0x180F0FC00")]
			set
			{
			}
		}

		// Token: 0x06016AC7 RID: 92871 RVA: 0x000925E0 File Offset: 0x000907E0
		[Token(Token = "0x6016AC7")]
		[Address(RVA = "0xF0EB00", Offset = "0xF0D700", VA = "0x180F0EB00")]
		public bool LoadSpine(string skinId, [Optional] UICharSpineHolder.LoadSpineParam overrideParam)
		{
			return default(bool);
		}

		// Token: 0x06016AC8 RID: 92872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016AC8")]
		[Address(RVA = "0xF0ECC0", Offset = "0xF0D8C0", VA = "0x180F0ECC0")]
		public void ReleaseIfNot()
		{
		}

		// Token: 0x06016AC9 RID: 92873 RVA: 0x000925F8 File Offset: 0x000907F8
		[Token(Token = "0x6016AC9")]
		[Address(RVA = "0xF0F620", Offset = "0xF0E220", VA = "0x180F0F620")]
		private bool _LoadBuildingSpine(string skinId)
		{
			return default(bool);
		}

		// Token: 0x06016ACA RID: 92874 RVA: 0x00092610 File Offset: 0x00090810
		[Token(Token = "0x6016ACA")]
		[Address(RVA = "0xF0EFC0", Offset = "0xF0DBC0", VA = "0x180F0EFC0")]
		private bool _LoadBattleSpine(string skinId)
		{
			return default(bool);
		}

		// Token: 0x06016ACB RID: 92875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016ACB")]
		[Address(RVA = "0xF0F980", Offset = "0xF0E580", VA = "0x180F0F980")]
		private IEnumerator _LoadSpineGraphic(SkeletonAnimation skeletonAnimation)
		{
			return null;
		}

		// Token: 0x06016ACC RID: 92876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ACC")]
		[Address(RVA = "0xF0E890", Offset = "0xF0D490", VA = "0x180F0E890")]
		private void Awake()
		{
		}

		// Token: 0x06016ACD RID: 92877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ACD")]
		[Address(RVA = "0xF0EE30", Offset = "0xF0DA30", VA = "0x180F0EE30")]
		private void Start()
		{
		}

		// Token: 0x06016ACE RID: 92878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ACE")]
		[Address(RVA = "0xF0EC60", Offset = "0xF0D860", VA = "0x180F0EC60")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016ACF RID: 92879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016ACF")]
		[Address(RVA = "0xF0FA50", Offset = "0xF0E650", VA = "0x180F0FA50")]
		public UICharSpineHolder()
		{
		}

		// Token: 0x0401B52E RID: 111918
		[Token(Token = "0x401B52E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICharSpineHolder.SpineType _spineType;

		// Token: 0x0401B52F RID: 111919
		[Token(Token = "0x401B52F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _loadOnStart;

		// Token: 0x0401B530 RID: 111920
		[Token(Token = "0x401B530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Inspect("loadOnStart")]
		private string _charSkinIdToLoad;

		// Token: 0x0401B531 RID: 111921
		[Token(Token = "0x401B531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material m_material;

		// Token: 0x0401B532 RID: 111922
		[Token(Token = "0x401B532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityEngine.Object m_dataSource;

		// Token: 0x0401B533 RID: 111923
		[Token(Token = "0x401B533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private UICharSpineHolder.LoadSpineParam m_loadParam;

		// Token: 0x0401B534 RID: 111924
		[Token(Token = "0x401B534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_loadOnStart;

		// Token: 0x0401B535 RID: 111925
		[Token(Token = "0x401B535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isLoaded;

		// Token: 0x0401B536 RID: 111926
		[Token(Token = "0x401B536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_CharSkinId;

		// Token: 0x0401B537 RID: 111927
		[Token(Token = "0x401B537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_CharSkinId;

		// Token: 0x0401B538 RID: 111928
		[Token(Token = "0x401B538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadSpine;

		// Token: 0x0401B539 RID: 111929
		[Token(Token = "0x401B539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ReleaseIfNot;

		// Token: 0x0401B53A RID: 111930
		[Token(Token = "0x401B53A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadBuildingSpine;

		// Token: 0x0401B53B RID: 111931
		[Token(Token = "0x401B53B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadBattleSpine;

		// Token: 0x0401B53C RID: 111932
		[Token(Token = "0x401B53C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadSpineGraphic;

		// Token: 0x0401B53D RID: 111933
		[Token(Token = "0x401B53D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0401B53E RID: 111934
		[Token(Token = "0x401B53E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B53F RID: 111935
		[Token(Token = "0x401B53F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B540 RID: 111936
		[Token(Token = "0x401B540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020037DC RID: 14300
		[Token(Token = "0x20037DC")]
		public enum SpineType
		{
			// Token: 0x0401B542 RID: 111938
			[Token(Token = "0x401B542")]
			BUILDING,
			// Token: 0x0401B543 RID: 111939
			[Token(Token = "0x401B543")]
			BATTLE
		}

		// Token: 0x020037DD RID: 14301
		[Token(Token = "0x20037DD")]
		public enum PlayAnimOption
		{
			// Token: 0x0401B545 RID: 111941
			[Token(Token = "0x401B545")]
			LOOP,
			// Token: 0x0401B546 RID: 111942
			[Token(Token = "0x401B546")]
			PLAY_ONCE,
			// Token: 0x0401B547 RID: 111943
			[Token(Token = "0x401B547")]
			STOP
		}

		// Token: 0x020037DE RID: 14302
		[Token(Token = "0x20037DE")]
		public class LoadSpineParam
		{
			// Token: 0x06016AD0 RID: 92880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016AD0")]
			[Address(RVA = "0xF068D0", Offset = "0xF054D0", VA = "0x180F068D0")]
			public LoadSpineParam()
			{
			}

			// Token: 0x0401B548 RID: 111944
			[Token(Token = "0x401B548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string animName;

			// Token: 0x0401B549 RID: 111945
			[Token(Token = "0x401B549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string defaultAnimName;

			// Token: 0x0401B54A RID: 111946
			[Token(Token = "0x401B54A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int framePercent;

			// Token: 0x0401B54B RID: 111947
			[Token(Token = "0x401B54B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public UICharSpineHolder.PlayAnimOption animOption;

			// Token: 0x0401B54C RID: 111948
			[Token(Token = "0x401B54C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 localPosition;

			// Token: 0x0401B54D RID: 111949
			[Token(Token = "0x401B54D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Quaternion localRotation;

			// Token: 0x0401B54E RID: 111950
			[Token(Token = "0x401B54E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Vector3 localScale;
		}
	}
}
