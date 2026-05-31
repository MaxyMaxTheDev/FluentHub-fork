// Copyright (c) 2022-2024 0x5BFA
// Licensed under the MIT License. See the LICENSE.

#nullable enable

namespace FluentHub.Octokit.Models.v4
{
	public class _Entity
	{
		/// <summary>
		/// Represents an 'added_to_merge_queue' event on a given pull request.
		/// </summary>
		public AddedToMergeQueueEvent? AddedToMergeQueueEvent { get; set; }

		/// <summary>
		/// Represents a 'added_to_project' event on a given issue or pull request.
		/// </summary>
		public AddedToProjectEvent? AddedToProjectEvent { get; set; }

		/// <summary>
		/// Represents a 'added_to_project_v2' event on a given issue or pull request.
		/// </summary>
		public AddedToProjectV2Event? AddedToProjectV2Event { get; set; }

		/// <summary>
		/// A GitHub App.
		/// </summary>
		public App? App { get; set; }

		/// <summary>
		/// Represents an 'assigned' event on any assignable object.
		/// </summary>
		public AssignedEvent? AssignedEvent { get; set; }

		/// <summary>
		/// Represents a 'auto_merge_disabled' event on a given pull request.
		/// </summary>
		public AutoMergeDisabledEvent? AutoMergeDisabledEvent { get; set; }

		/// <summary>
		/// Represents a 'auto_merge_enabled' event on a given pull request.
		/// </summary>
		public AutoMergeEnabledEvent? AutoMergeEnabledEvent { get; set; }

		/// <summary>
		/// Represents a 'auto_rebase_enabled' event on a given pull request.
		/// </summary>
		public AutoRebaseEnabledEvent? AutoRebaseEnabledEvent { get; set; }

		/// <summary>
		/// Represents a 'auto_squash_enabled' event on a given pull request.
		/// </summary>
		public AutoSquashEnabledEvent? AutoSquashEnabledEvent { get; set; }

		/// <summary>
		/// Represents a 'automatic_base_change_failed' event on a given pull request.
		/// </summary>
		public AutomaticBaseChangeFailedEvent? AutomaticBaseChangeFailedEvent { get; set; }

		/// <summary>
		/// Represents a 'automatic_base_change_succeeded' event on a given pull request.
		/// </summary>
		public AutomaticBaseChangeSucceededEvent? AutomaticBaseChangeSucceededEvent { get; set; }

		/// <summary>
		/// Represents a 'base_ref_changed' event on a given issue or pull request.
		/// </summary>
		public BaseRefChangedEvent? BaseRefChangedEvent { get; set; }

		/// <summary>
		/// Represents a 'base_ref_deleted' event on a given pull request.
		/// </summary>
		public BaseRefDeletedEvent? BaseRefDeletedEvent { get; set; }

		/// <summary>
		/// Represents a 'base_ref_force_pushed' event on a given pull request.
		/// </summary>
		public BaseRefForcePushedEvent? BaseRefForcePushedEvent { get; set; }

		/// <summary>
		/// Represents a Git blob.
		/// </summary>
		public Blob? Blob { get; set; }

		/// <summary>
		/// Represents a 'blocked_by_added' event on a given issue.
		/// </summary>
		public BlockedByAddedEvent? BlockedByAddedEvent { get; set; }

		/// <summary>
		/// Represents a 'blocked_by_removed' event on a given issue.
		/// </summary>
		public BlockedByRemovedEvent? BlockedByRemovedEvent { get; set; }

		/// <summary>
		/// Represents a 'blocking_added' event on a given issue.
		/// </summary>
		public BlockingAddedEvent? BlockingAddedEvent { get; set; }

		/// <summary>
		/// Represents a 'blocking_removed' event on a given issue.
		/// </summary>
		public BlockingRemovedEvent? BlockingRemovedEvent { get; set; }

		/// <summary>
		/// A special type of user which takes actions on behalf of GitHub Apps.
		/// </summary>
		public Bot? Bot { get; set; }

		/// <summary>
		/// A branch protection rule.
		/// </summary>
		public BranchProtectionRule? BranchProtectionRule { get; set; }

		/// <summary>
		/// A user, team, or app who has the ability to bypass a force push requirement on a protected branch.
		/// </summary>
		public BypassForcePushAllowance? BypassForcePushAllowance { get; set; }

		/// <summary>
		/// A user, team, or app who has the ability to bypass a pull request requirement on a protected branch.
		/// </summary>
		public BypassPullRequestAllowance? BypassPullRequestAllowance { get; set; }

		/// <summary>
		/// A common weakness enumeration
		/// </summary>
		public CWE? CWE { get; set; }

		/// <summary>
		/// A check run.
		/// </summary>
		public CheckRun? CheckRun { get; set; }

		/// <summary>
		/// A check suite.
		/// </summary>
		public CheckSuite? CheckSuite { get; set; }

		/// <summary>
		/// Represents a 'closed' event on any `Closable`.
		/// </summary>
		public ClosedEvent? ClosedEvent { get; set; }

		/// <summary>
		/// The Code of Conduct for a repository
		/// </summary>
		public CodeOfConduct? CodeOfConduct { get; set; }

		/// <summary>
		/// Represents a 'comment_deleted' event on a given issue or pull request.
		/// </summary>
		public CommentDeletedEvent? CommentDeletedEvent { get; set; }

		/// <summary>
		/// Represents a Git commit.
		/// </summary>
		public Commit? Commit { get; set; }

		/// <summary>
		/// Represents a comment on a given Commit.
		/// </summary>
		public CommitComment? CommitComment { get; set; }

		/// <summary>
		/// A thread of comments on a commit.
		/// </summary>
		public CommitCommentThread? CommitCommentThread { get; set; }

		/// <summary>
		/// Represents a comparison between two commit revisions.
		/// </summary>
		public Comparison? Comparison { get; set; }

		/// <summary>
		/// Represents a 'connected' event on a given issue or pull request.
		/// </summary>
		public ConnectedEvent? ConnectedEvent { get; set; }

		/// <summary>
		/// Represents a 'convert_to_draft' event on a given pull request.
		/// </summary>
		public ConvertToDraftEvent? ConvertToDraftEvent { get; set; }

		/// <summary>
		/// Represents a 'converted_from_draft' event on a given issue or pull request.
		/// </summary>
		public ConvertedFromDraftEvent? ConvertedFromDraftEvent { get; set; }

		/// <summary>
		/// Represents a 'converted_note_to_issue' event on a given issue or pull request.
		/// </summary>
		public ConvertedNoteToIssueEvent? ConvertedNoteToIssueEvent { get; set; }

		/// <summary>
		/// Represents a 'converted_to_discussion' event on a given issue.
		/// </summary>
		public ConvertedToDiscussionEvent? ConvertedToDiscussionEvent { get; set; }

		/// <summary>
		/// Represents a mention made by one issue or pull request to another.
		/// </summary>
		public CrossReferencedEvent? CrossReferencedEvent { get; set; }

		/// <summary>
		/// Represents a 'demilestoned' event on a given issue or pull request.
		/// </summary>
		public DemilestonedEvent? DemilestonedEvent { get; set; }

		/// <summary>
		/// Dependency manifest for a repository
		/// </summary>
		public DependencyGraphManifest? DependencyGraphManifest { get; set; }

		/// <summary>
		/// A repository deploy key.
		/// </summary>
		public DeployKey? DeployKey { get; set; }

		/// <summary>
		/// Represents a 'deployed' event on a given pull request.
		/// </summary>
		public DeployedEvent? DeployedEvent { get; set; }

		/// <summary>
		/// Represents triggered deployment instance.
		/// </summary>
		public Deployment? Deployment { get; set; }

		/// <summary>
		/// Represents a 'deployment_environment_changed' event on a given pull request.
		/// </summary>
		public DeploymentEnvironmentChangedEvent? DeploymentEnvironmentChangedEvent { get; set; }

		/// <summary>
		/// A deployment review.
		/// </summary>
		public DeploymentReview? DeploymentReview { get; set; }

		/// <summary>
		/// Describes the status of a given deployment attempt.
		/// </summary>
		public DeploymentStatus? DeploymentStatus { get; set; }

		/// <summary>
		/// Represents a 'disconnected' event on a given issue or pull request.
		/// </summary>
		public DisconnectedEvent? DisconnectedEvent { get; set; }

		/// <summary>
		/// A discussion in a repository.
		/// </summary>
		public Discussion? Discussion { get; set; }

		/// <summary>
		/// A category for discussions in a repository.
		/// </summary>
		public DiscussionCategory? DiscussionCategory { get; set; }

		/// <summary>
		/// A comment on a discussion.
		/// </summary>
		public DiscussionComment? DiscussionComment { get; set; }

		/// <summary>
		/// A poll for a discussion.
		/// </summary>
		public DiscussionPoll? DiscussionPoll { get; set; }

		/// <summary>
		/// An option for a discussion poll.
		/// </summary>
		public DiscussionPollOption? DiscussionPollOption { get; set; }

		/// <summary>
		/// A draft issue within a project.
		/// </summary>
		public DraftIssue? DraftIssue { get; set; }

		/// <summary>
		/// An account to manage multiple organizations with consolidated policy and billing.
		/// </summary>
		public Enterprise? Enterprise { get; set; }

		/// <summary>
		/// An invitation for a user to become an owner or billing manager of an enterprise.
		/// </summary>
		public EnterpriseAdministratorInvitation? EnterpriseAdministratorInvitation { get; set; }

		/// <summary>
		/// An identity provider configured to provision identities for an enterprise. Visible to enterprise owners or enterprise owners' personal access tokens (classic) with read:enterprise or admin:enterprise scope.
		/// </summary>
		public EnterpriseIdentityProvider? EnterpriseIdentityProvider { get; set; }

		/// <summary>
		/// An invitation for a user to become an unaffiliated member of an enterprise.
		/// </summary>
		public EnterpriseMemberInvitation? EnterpriseMemberInvitation { get; set; }

		/// <summary>
		/// A subset of repository information queryable from an enterprise.
		/// </summary>
		public EnterpriseRepositoryInfo? EnterpriseRepositoryInfo { get; set; }

		/// <summary>
		/// An Enterprise Server installation.
		/// </summary>
		public EnterpriseServerInstallation? EnterpriseServerInstallation { get; set; }

		/// <summary>
		/// A user account on an Enterprise Server installation.
		/// </summary>
		public EnterpriseServerUserAccount? EnterpriseServerUserAccount { get; set; }

		/// <summary>
		/// An email belonging to a user account on an Enterprise Server installation.
		/// </summary>
		public EnterpriseServerUserAccountEmail? EnterpriseServerUserAccountEmail { get; set; }

		/// <summary>
		/// A user accounts upload from an Enterprise Server installation.
		/// </summary>
		public EnterpriseServerUserAccountsUpload? EnterpriseServerUserAccountsUpload { get; set; }

		/// <summary>
		/// A team that belongs to an enterprise and can be assigned to multiple organizations.
		/// </summary>
		public EnterpriseTeam? EnterpriseTeam { get; set; }

		/// <summary>
		/// An account for a user who is an admin of an enterprise or a member of an enterprise through one or more organizations.
		/// </summary>
		public EnterpriseUserAccount? EnterpriseUserAccount { get; set; }

		/// <summary>
		/// An environment.
		/// </summary>
		public Environment? Environment { get; set; }

		/// <summary>
		/// An external identity provisioned by SAML SSO or SCIM. If SAML is configured on the organization, the external identity is visible to (1) organization owners, (2) organization owners' personal access tokens (classic) with read:org or admin:org scope, (3) GitHub App with an installation token with read or write access to members. If SAML is configured on the enterprise, the external identity is visible to (1) enterprise owners, (2) enterprise owners' personal access tokens (classic) with read:enterprise or admin:enterprise scope.
		/// </summary>
		public ExternalIdentity? ExternalIdentity { get; set; }

		/// <summary>
		/// A Gist.
		/// </summary>
		public Gist? Gist { get; set; }

		/// <summary>
		/// Represents a comment on an Gist.
		/// </summary>
		public GistComment? GistComment { get; set; }

		/// <summary>
		/// Represents a 'head_ref_deleted' event on a given pull request.
		/// </summary>
		public HeadRefDeletedEvent? HeadRefDeletedEvent { get; set; }

		/// <summary>
		/// Represents a 'head_ref_force_pushed' event on a given pull request.
		/// </summary>
		public HeadRefForcePushedEvent? HeadRefForcePushedEvent { get; set; }

		/// <summary>
		/// Represents a 'head_ref_restored' event on a given pull request.
		/// </summary>
		public HeadRefRestoredEvent? HeadRefRestoredEvent { get; set; }

		/// <summary>
		/// An IP address or range of addresses that is allowed to access an owner's resources.
		/// </summary>
		public IpAllowListEntry? IpAllowListEntry { get; set; }

		/// <summary>
		/// An Issue is a place to discuss ideas, enhancements, tasks, and bugs for a project.
		/// </summary>
		public Issue? Issue { get; set; }

		/// <summary>
		/// Represents a comment on an Issue.
		/// </summary>
		public IssueComment? IssueComment { get; set; }

		/// <summary>
		/// Represents a 'issue_comment_pinned' event on a given issue.
		/// </summary>
		public IssueCommentPinnedEvent? IssueCommentPinnedEvent { get; set; }

		/// <summary>
		/// Represents a 'issue_comment_unpinned' event on a given issue.
		/// </summary>
		public IssueCommentUnpinnedEvent? IssueCommentUnpinnedEvent { get; set; }

		/// <summary>
		/// Represents a 'issue_field_added' event on a given issue.
		/// </summary>
		public IssueFieldAddedEvent? IssueFieldAddedEvent { get; set; }

		/// <summary>
		/// Represents a 'issue_field_changed' event on a given issue.
		/// </summary>
		public IssueFieldChangedEvent? IssueFieldChangedEvent { get; set; }

		/// <summary>
		/// Represents a date issue field.
		/// </summary>
		public IssueFieldDate? IssueFieldDate { get; set; }

		/// <summary>
		/// The value of a date field in an Issue item.
		/// </summary>
		public IssueFieldDateValue? IssueFieldDateValue { get; set; }

		/// <summary>
		/// Represents a number issue field.
		/// </summary>
		public IssueFieldNumber? IssueFieldNumber { get; set; }

		/// <summary>
		/// The value of a number field in an Issue item.
		/// </summary>
		public IssueFieldNumberValue? IssueFieldNumberValue { get; set; }

		/// <summary>
		/// Represents a 'issue_field_removed' event on a given issue.
		/// </summary>
		public IssueFieldRemovedEvent? IssueFieldRemovedEvent { get; set; }

		/// <summary>
		/// Represents a single select issue field.
		/// </summary>
		public IssueFieldSingleSelect? IssueFieldSingleSelect { get; set; }

		/// <summary>
		/// Represents an option in a single-select issue field.
		/// </summary>
		public IssueFieldSingleSelectOption? IssueFieldSingleSelectOption { get; set; }

		/// <summary>
		/// The value of a single select field in an Issue item.
		/// </summary>
		public IssueFieldSingleSelectValue? IssueFieldSingleSelectValue { get; set; }

		/// <summary>
		/// Represents a text issue field.
		/// </summary>
		public IssueFieldText? IssueFieldText { get; set; }

		/// <summary>
		/// The value of a text field in an Issue item.
		/// </summary>
		public IssueFieldTextValue? IssueFieldTextValue { get; set; }

		/// <summary>
		/// Represents the type of Issue.
		/// </summary>
		public IssueType? IssueType { get; set; }

		/// <summary>
		/// Represents a 'issue_type_added' event on a given issue.
		/// </summary>
		public IssueTypeAddedEvent? IssueTypeAddedEvent { get; set; }

		/// <summary>
		/// Represents a 'issue_type_changed' event on a given issue.
		/// </summary>
		public IssueTypeChangedEvent? IssueTypeChangedEvent { get; set; }

		/// <summary>
		/// Represents a 'issue_type_removed' event on a given issue.
		/// </summary>
		public IssueTypeRemovedEvent? IssueTypeRemovedEvent { get; set; }

		/// <summary>
		/// A label for categorizing Issues, Pull Requests, Milestones, or Discussions with a given Repository.
		/// </summary>
		public Label? Label { get; set; }

		/// <summary>
		/// Represents a 'labeled' event on a given issue or pull request.
		/// </summary>
		public LabeledEvent? LabeledEvent { get; set; }

		/// <summary>
		/// Represents a given language found in repositories.
		/// </summary>
		public Language? Language { get; set; }

		/// <summary>
		/// A repository's open source license
		/// </summary>
		public License? License { get; set; }

		/// <summary>
		/// A branch linked to an issue.
		/// </summary>
		public LinkedBranch? LinkedBranch { get; set; }

		/// <summary>
		/// Represents a 'locked' event on a given issue or pull request.
		/// </summary>
		public LockedEvent? LockedEvent { get; set; }

		/// <summary>
		/// A placeholder user for attribution of imported data on GitHub.
		/// </summary>
		public Mannequin? Mannequin { get; set; }

		/// <summary>
		/// Represents a 'marked_as_duplicate' event on a given issue or pull request.
		/// </summary>
		public MarkedAsDuplicateEvent? MarkedAsDuplicateEvent { get; set; }

		/// <summary>
		/// A public description of a Marketplace category.
		/// </summary>
		public MarketplaceCategory? MarketplaceCategory { get; set; }

		/// <summary>
		/// A listing in the GitHub integration marketplace.
		/// </summary>
		public MarketplaceListing? MarketplaceListing { get; set; }

		/// <summary>
		/// Represents a member feature request notification
		/// </summary>
		public MemberFeatureRequestNotification? MemberFeatureRequestNotification { get; set; }

		/// <summary>
		/// Audit log entry for a members_can_delete_repos.clear event.
		/// </summary>
		public MembersCanDeleteReposClearAuditEntry? MembersCanDeleteReposClearAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a members_can_delete_repos.disable event.
		/// </summary>
		public MembersCanDeleteReposDisableAuditEntry? MembersCanDeleteReposDisableAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a members_can_delete_repos.enable event.
		/// </summary>
		public MembersCanDeleteReposEnableAuditEntry? MembersCanDeleteReposEnableAuditEntry { get; set; }

		/// <summary>
		/// Represents a 'mentioned' event on a given issue or pull request.
		/// </summary>
		public MentionedEvent? MentionedEvent { get; set; }

		/// <summary>
		/// The queue of pull request entries to be merged into a protected branch in a repository.
		/// </summary>
		public MergeQueue? MergeQueue { get; set; }

		/// <summary>
		/// Entries in a MergeQueue
		/// </summary>
		public MergeQueueEntry? MergeQueueEntry { get; set; }

		/// <summary>
		/// Represents a 'merged' event on a given pull request.
		/// </summary>
		public MergedEvent? MergedEvent { get; set; }

		/// <summary>
		/// A GitHub Enterprise Importer (GEI) migration source.
		/// </summary>
		public MigrationSource? MigrationSource { get; set; }

		/// <summary>
		/// Represents a Milestone object on a given repository.
		/// </summary>
		public Milestone? Milestone { get; set; }

		/// <summary>
		/// Represents a 'milestoned' event on a given issue or pull request.
		/// </summary>
		public MilestonedEvent? MilestonedEvent { get; set; }

		/// <summary>
		/// Represents a 'moved_columns_in_project' event on a given issue or pull request.
		/// </summary>
		public MovedColumnsInProjectEvent? MovedColumnsInProjectEvent { get; set; }

		/// <summary>
		/// An OIDC identity provider configured to provision identities for an enterprise. Visible to enterprise owners or enterprise owners' personal access tokens (classic) with read:enterprise or admin:enterprise scope.
		/// </summary>
		public OIDCProvider? OIDCProvider { get; set; }

		/// <summary>
		/// Audit log entry for a oauth_application.create event.
		/// </summary>
		public OauthApplicationCreateAuditEntry? OauthApplicationCreateAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.add_billing_manager
		/// </summary>
		public OrgAddBillingManagerAuditEntry? OrgAddBillingManagerAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.add_member
		/// </summary>
		public OrgAddMemberAuditEntry? OrgAddMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.block_user
		/// </summary>
		public OrgBlockUserAuditEntry? OrgBlockUserAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.config.disable_collaborators_only event.
		/// </summary>
		public OrgConfigDisableCollaboratorsOnlyAuditEntry? OrgConfigDisableCollaboratorsOnlyAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.config.enable_collaborators_only event.
		/// </summary>
		public OrgConfigEnableCollaboratorsOnlyAuditEntry? OrgConfigEnableCollaboratorsOnlyAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.create event.
		/// </summary>
		public OrgCreateAuditEntry? OrgCreateAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.disable_oauth_app_restrictions event.
		/// </summary>
		public OrgDisableOauthAppRestrictionsAuditEntry? OrgDisableOauthAppRestrictionsAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.disable_saml event.
		/// </summary>
		public OrgDisableSamlAuditEntry? OrgDisableSamlAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.disable_two_factor_requirement event.
		/// </summary>
		public OrgDisableTwoFactorRequirementAuditEntry? OrgDisableTwoFactorRequirementAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.enable_oauth_app_restrictions event.
		/// </summary>
		public OrgEnableOauthAppRestrictionsAuditEntry? OrgEnableOauthAppRestrictionsAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.enable_saml event.
		/// </summary>
		public OrgEnableSamlAuditEntry? OrgEnableSamlAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.enable_two_factor_requirement event.
		/// </summary>
		public OrgEnableTwoFactorRequirementAuditEntry? OrgEnableTwoFactorRequirementAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.invite_member event.
		/// </summary>
		public OrgInviteMemberAuditEntry? OrgInviteMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.invite_to_business event.
		/// </summary>
		public OrgInviteToBusinessAuditEntry? OrgInviteToBusinessAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.oauth_app_access_approved event.
		/// </summary>
		public OrgOauthAppAccessApprovedAuditEntry? OrgOauthAppAccessApprovedAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.oauth_app_access_blocked event.
		/// </summary>
		public OrgOauthAppAccessBlockedAuditEntry? OrgOauthAppAccessBlockedAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.oauth_app_access_denied event.
		/// </summary>
		public OrgOauthAppAccessDeniedAuditEntry? OrgOauthAppAccessDeniedAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.oauth_app_access_requested event.
		/// </summary>
		public OrgOauthAppAccessRequestedAuditEntry? OrgOauthAppAccessRequestedAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.oauth_app_access_unblocked event.
		/// </summary>
		public OrgOauthAppAccessUnblockedAuditEntry? OrgOauthAppAccessUnblockedAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.remove_billing_manager event.
		/// </summary>
		public OrgRemoveBillingManagerAuditEntry? OrgRemoveBillingManagerAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.remove_member event.
		/// </summary>
		public OrgRemoveMemberAuditEntry? OrgRemoveMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.remove_outside_collaborator event.
		/// </summary>
		public OrgRemoveOutsideCollaboratorAuditEntry? OrgRemoveOutsideCollaboratorAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.restore_member event.
		/// </summary>
		public OrgRestoreMemberAuditEntry? OrgRestoreMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.unblock_user
		/// </summary>
		public OrgUnblockUserAuditEntry? OrgUnblockUserAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.update_default_repository_permission
		/// </summary>
		public OrgUpdateDefaultRepositoryPermissionAuditEntry? OrgUpdateDefaultRepositoryPermissionAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.update_member event.
		/// </summary>
		public OrgUpdateMemberAuditEntry? OrgUpdateMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.update_member_repository_creation_permission event.
		/// </summary>
		public OrgUpdateMemberRepositoryCreationPermissionAuditEntry? OrgUpdateMemberRepositoryCreationPermissionAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a org.update_member_repository_invitation_permission event.
		/// </summary>
		public OrgUpdateMemberRepositoryInvitationPermissionAuditEntry? OrgUpdateMemberRepositoryInvitationPermissionAuditEntry { get; set; }

		/// <summary>
		/// An account on GitHub, with one or more owners, that has repositories, members and teams.
		/// </summary>
		public Organization? Organization { get; set; }

		/// <summary>
		/// An Identity Provider configured to provision SAML and SCIM identities for Organizations. Visible to (1) organization owners, (2) organization owners' personal access tokens (classic) with read:org or admin:org scope, (3) GitHub App with an installation token with read or write access to members.
		/// </summary>
		public OrganizationIdentityProvider? OrganizationIdentityProvider { get; set; }

		/// <summary>
		/// An Invitation for a user to an organization.
		/// </summary>
		public OrganizationInvitation? OrganizationInvitation { get; set; }

		/// <summary>
		/// Information for an uploaded package.
		/// </summary>
		public Package? Package { get; set; }

		/// <summary>
		/// A file in a package version.
		/// </summary>
		public PackageFile? PackageFile { get; set; }

		/// <summary>
		/// A version tag contains the mapping between a tag name and a version.
		/// </summary>
		public PackageTag? PackageTag { get; set; }

		/// <summary>
		/// Information about a specific package version.
		/// </summary>
		public PackageVersion? PackageVersion { get; set; }

		/// <summary>
		/// Represents a 'parent_issue_added' event on a given issue.
		/// </summary>
		public ParentIssueAddedEvent? ParentIssueAddedEvent { get; set; }

		/// <summary>
		/// Represents a 'parent_issue_removed' event on a given issue.
		/// </summary>
		public ParentIssueRemovedEvent? ParentIssueRemovedEvent { get; set; }

		/// <summary>
		/// A Pinned Discussion is a discussion pinned to a repository's index page.
		/// </summary>
		public PinnedDiscussion? PinnedDiscussion { get; set; }

		/// <summary>
		/// Represents a pinned environment on a given repository
		/// </summary>
		public PinnedEnvironment? PinnedEnvironment { get; set; }

		/// <summary>
		/// Represents a 'pinned' event on a given issue or pull request.
		/// </summary>
		public PinnedEvent? PinnedEvent { get; set; }

		/// <summary>
		/// A Pinned Issue is a issue pinned to a repository's index page.
		/// </summary>
		public PinnedIssue? PinnedIssue { get; set; }

		/// <summary>
		/// A comment pinned to an Issue.
		/// </summary>
		public PinnedIssueComment? PinnedIssueComment { get; set; }

		/// <summary>
		/// Audit log entry for a private_repository_forking.disable event.
		/// </summary>
		public PrivateRepositoryForkingDisableAuditEntry? PrivateRepositoryForkingDisableAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a private_repository_forking.enable event.
		/// </summary>
		public PrivateRepositoryForkingEnableAuditEntry? PrivateRepositoryForkingEnableAuditEntry { get; set; }

		/// <summary>
		/// Projects manage issues, pull requests and notes within a project owner.
		/// </summary>
		public Project? Project { get; set; }

		/// <summary>
		/// A card in a project.
		/// </summary>
		public ProjectCard? ProjectCard { get; set; }

		/// <summary>
		/// A column inside a project.
		/// </summary>
		public ProjectColumn? ProjectColumn { get; set; }

		/// <summary>
		/// New projects that manage issues, pull requests and drafts using tables and boards.
		/// </summary>
		public ProjectV2? ProjectV2 { get; set; }

		/// <summary>
		/// A field inside a project.
		/// </summary>
		public ProjectV2Field? ProjectV2Field { get; set; }

		/// <summary>
		/// An item within a Project.
		/// </summary>
		public ProjectV2Item? ProjectV2Item { get; set; }

		/// <summary>
		/// The value of a date field in a Project item.
		/// </summary>
		public ProjectV2ItemFieldDateValue? ProjectV2ItemFieldDateValue { get; set; }

		/// <summary>
		/// The value of an iteration field in a Project item.
		/// </summary>
		public ProjectV2ItemFieldIterationValue? ProjectV2ItemFieldIterationValue { get; set; }

		/// <summary>
		/// The value of a number field in a Project item.
		/// </summary>
		public ProjectV2ItemFieldNumberValue? ProjectV2ItemFieldNumberValue { get; set; }

		/// <summary>
		/// The value of a single select field in a Project item.
		/// </summary>
		public ProjectV2ItemFieldSingleSelectValue? ProjectV2ItemFieldSingleSelectValue { get; set; }

		/// <summary>
		/// The value of a text field in a Project item.
		/// </summary>
		public ProjectV2ItemFieldTextValue? ProjectV2ItemFieldTextValue { get; set; }

		/// <summary>
		/// Represents a 'project_v2_item_status_changed' event on a given issue or pull request.
		/// </summary>
		public ProjectV2ItemStatusChangedEvent? ProjectV2ItemStatusChangedEvent { get; set; }

		/// <summary>
		/// An iteration field inside a project.
		/// </summary>
		public ProjectV2IterationField? ProjectV2IterationField { get; set; }

		/// <summary>
		/// A single select field inside a project.
		/// </summary>
		public ProjectV2SingleSelectField? ProjectV2SingleSelectField { get; set; }

		/// <summary>
		/// A status update within a project.
		/// </summary>
		public ProjectV2StatusUpdate? ProjectV2StatusUpdate { get; set; }

		/// <summary>
		/// A view within a ProjectV2.
		/// </summary>
		public ProjectV2View? ProjectV2View { get; set; }

		/// <summary>
		/// A workflow inside a project.
		/// </summary>
		public ProjectV2Workflow? ProjectV2Workflow { get; set; }

		/// <summary>
		/// A user's public key.
		/// </summary>
		public PublicKey? PublicKey { get; set; }

		/// <summary>
		/// A repository pull request.
		/// </summary>
		public PullRequest? PullRequest { get; set; }

		/// <summary>
		/// Represents a Git commit part of a pull request.
		/// </summary>
		public PullRequestCommit? PullRequestCommit { get; set; }

		/// <summary>
		/// Represents a commit comment thread part of a pull request.
		/// </summary>
		public PullRequestCommitCommentThread? PullRequestCommitCommentThread { get; set; }

		/// <summary>
		/// A review object for a given pull request.
		/// </summary>
		public PullRequestReview? PullRequestReview { get; set; }

		/// <summary>
		/// A review comment associated with a given repository pull request.
		/// </summary>
		public PullRequestReviewComment? PullRequestReviewComment { get; set; }

		/// <summary>
		/// A threaded list of comments for a given pull request.
		/// </summary>
		public PullRequestReviewThread? PullRequestReviewThread { get; set; }

		/// <summary>
		/// A threaded list of comments for a given pull request.
		/// </summary>
		public PullRequestThread? PullRequestThread { get; set; }

		/// <summary>
		/// A Git push.
		/// </summary>
		public Push? Push { get; set; }

		/// <summary>
		/// A team, user, or app who has the ability to push to a protected branch.
		/// </summary>
		public PushAllowance? PushAllowance { get; set; }

		/// <summary>
		/// The query root of GitHub's GraphQL interface.
		/// </summary>
		public Query? Query { get; set; }

		/// <summary>
		/// An emoji reaction to a particular piece of content.
		/// </summary>
		public Reaction? Reaction { get; set; }

		/// <summary>
		/// Represents a 'ready_for_review' event on a given pull request.
		/// </summary>
		public ReadyForReviewEvent? ReadyForReviewEvent { get; set; }

		/// <summary>
		/// Represents a Git reference.
		/// </summary>
		public Ref? Ref { get; set; }

		/// <summary>
		/// Represents a 'referenced' event on a given `ReferencedSubject`.
		/// </summary>
		public ReferencedEvent? ReferencedEvent { get; set; }

		/// <summary>
		/// A release contains the content for a release.
		/// </summary>
		public Release? Release { get; set; }

		/// <summary>
		/// A release asset contains the content for a release asset.
		/// </summary>
		public ReleaseAsset? ReleaseAsset { get; set; }

		/// <summary>
		/// Represents a 'removed_from_merge_queue' event on a given pull request.
		/// </summary>
		public RemovedFromMergeQueueEvent? RemovedFromMergeQueueEvent { get; set; }

		/// <summary>
		/// Represents a 'removed_from_project' event on a given issue or pull request.
		/// </summary>
		public RemovedFromProjectEvent? RemovedFromProjectEvent { get; set; }

		/// <summary>
		/// Represents a 'removed_from_project_v2' event on a given issue or pull request.
		/// </summary>
		public RemovedFromProjectV2Event? RemovedFromProjectV2Event { get; set; }

		/// <summary>
		/// Represents a 'renamed' event on a given issue or pull request
		/// </summary>
		public RenamedTitleEvent? RenamedTitleEvent { get; set; }

		/// <summary>
		/// Represents a 'reopened' event on any `Closable`.
		/// </summary>
		public ReopenedEvent? ReopenedEvent { get; set; }

		/// <summary>
		/// Audit log entry for a repo.access event.
		/// </summary>
		public RepoAccessAuditEntry? RepoAccessAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.add_member event.
		/// </summary>
		public RepoAddMemberAuditEntry? RepoAddMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.add_topic event.
		/// </summary>
		public RepoAddTopicAuditEntry? RepoAddTopicAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.archived event.
		/// </summary>
		public RepoArchivedAuditEntry? RepoArchivedAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.change_merge_setting event.
		/// </summary>
		public RepoChangeMergeSettingAuditEntry? RepoChangeMergeSettingAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.disable_anonymous_git_access event.
		/// </summary>
		public RepoConfigDisableAnonymousGitAccessAuditEntry? RepoConfigDisableAnonymousGitAccessAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.disable_collaborators_only event.
		/// </summary>
		public RepoConfigDisableCollaboratorsOnlyAuditEntry? RepoConfigDisableCollaboratorsOnlyAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.disable_contributors_only event.
		/// </summary>
		public RepoConfigDisableContributorsOnlyAuditEntry? RepoConfigDisableContributorsOnlyAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.disable_sockpuppet_disallowed event.
		/// </summary>
		public RepoConfigDisableSockpuppetDisallowedAuditEntry? RepoConfigDisableSockpuppetDisallowedAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.enable_anonymous_git_access event.
		/// </summary>
		public RepoConfigEnableAnonymousGitAccessAuditEntry? RepoConfigEnableAnonymousGitAccessAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.enable_collaborators_only event.
		/// </summary>
		public RepoConfigEnableCollaboratorsOnlyAuditEntry? RepoConfigEnableCollaboratorsOnlyAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.enable_contributors_only event.
		/// </summary>
		public RepoConfigEnableContributorsOnlyAuditEntry? RepoConfigEnableContributorsOnlyAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.enable_sockpuppet_disallowed event.
		/// </summary>
		public RepoConfigEnableSockpuppetDisallowedAuditEntry? RepoConfigEnableSockpuppetDisallowedAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.lock_anonymous_git_access event.
		/// </summary>
		public RepoConfigLockAnonymousGitAccessAuditEntry? RepoConfigLockAnonymousGitAccessAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.config.unlock_anonymous_git_access event.
		/// </summary>
		public RepoConfigUnlockAnonymousGitAccessAuditEntry? RepoConfigUnlockAnonymousGitAccessAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.create event.
		/// </summary>
		public RepoCreateAuditEntry? RepoCreateAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.destroy event.
		/// </summary>
		public RepoDestroyAuditEntry? RepoDestroyAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.remove_member event.
		/// </summary>
		public RepoRemoveMemberAuditEntry? RepoRemoveMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repo.remove_topic event.
		/// </summary>
		public RepoRemoveTopicAuditEntry? RepoRemoveTopicAuditEntry { get; set; }

		/// <summary>
		/// A repository contains the content for a project.
		/// </summary>
		public Repository? Repository { get; set; }

		/// <summary>
		/// A repository custom property.
		/// </summary>
		public RepositoryCustomProperty? RepositoryCustomProperty { get; set; }

		/// <summary>
		/// An invitation for a user to be added to a repository.
		/// </summary>
		public RepositoryInvitation? RepositoryInvitation { get; set; }

		/// <summary>
		/// A GitHub Enterprise Importer (GEI) repository migration.
		/// </summary>
		public RepositoryMigration? RepositoryMigration { get; set; }

		/// <summary>
		/// A repository rule.
		/// </summary>
		public RepositoryRule? RepositoryRule { get; set; }

		/// <summary>
		/// A repository ruleset.
		/// </summary>
		public RepositoryRuleset? RepositoryRuleset { get; set; }

		/// <summary>
		/// A team, app or user that has the ability to bypass rules defined on a ruleset
		/// </summary>
		public RepositoryRulesetBypassActor? RepositoryRulesetBypassActor { get; set; }

		/// <summary>
		/// A repository-topic connects a repository to a topic.
		/// </summary>
		public RepositoryTopic? RepositoryTopic { get; set; }

		/// <summary>
		/// Audit log entry for a repository_visibility_change.disable event.
		/// </summary>
		public RepositoryVisibilityChangeDisableAuditEntry? RepositoryVisibilityChangeDisableAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a repository_visibility_change.enable event.
		/// </summary>
		public RepositoryVisibilityChangeEnableAuditEntry? RepositoryVisibilityChangeEnableAuditEntry { get; set; }

		/// <summary>
		/// A Dependabot alert for a repository with a dependency affected by a security vulnerability.
		/// </summary>
		public RepositoryVulnerabilityAlert? RepositoryVulnerabilityAlert { get; set; }

		/// <summary>
		/// A user, team, or app who has the ability to dismiss a review on a protected branch.
		/// </summary>
		public ReviewDismissalAllowance? ReviewDismissalAllowance { get; set; }

		/// <summary>
		/// Represents a 'review_dismissed' event on a given issue or pull request.
		/// </summary>
		public ReviewDismissedEvent? ReviewDismissedEvent { get; set; }

		/// <summary>
		/// A request for a user to review a pull request.
		/// </summary>
		public ReviewRequest? ReviewRequest { get; set; }

		/// <summary>
		/// Represents an 'review_request_removed' event on a given pull request.
		/// </summary>
		public ReviewRequestRemovedEvent? ReviewRequestRemovedEvent { get; set; }

		/// <summary>
		/// Represents an 'review_requested' event on a given pull request.
		/// </summary>
		public ReviewRequestedEvent? ReviewRequestedEvent { get; set; }

		/// <summary>
		/// A Saved Reply is text a user can use to reply quickly.
		/// </summary>
		public SavedReply? SavedReply { get; set; }

		/// <summary>
		/// A GitHub Security Advisory
		/// </summary>
		public SecurityAdvisory? SecurityAdvisory { get; set; }

		/// <summary>
		/// An event related to sponsorship activity.
		/// </summary>
		public SponsorsActivity? SponsorsActivity { get; set; }

		/// <summary>
		/// A GitHub Sponsors listing.
		/// </summary>
		public SponsorsListing? SponsorsListing { get; set; }

		/// <summary>
		/// A record that is promoted on a GitHub Sponsors profile.
		/// </summary>
		public SponsorsListingFeaturedItem? SponsorsListingFeaturedItem { get; set; }

		/// <summary>
		/// A GitHub Sponsors tier associated with a GitHub Sponsors listing.
		/// </summary>
		public SponsorsTier? SponsorsTier { get; set; }

		/// <summary>
		/// A sponsorship relationship between a sponsor and a maintainer
		/// </summary>
		public Sponsorship? Sponsorship { get; set; }

		/// <summary>
		/// An update sent to sponsors of a user or organization on GitHub Sponsors.
		/// </summary>
		public SponsorshipNewsletter? SponsorshipNewsletter { get; set; }

		/// <summary>
		/// Represents a commit status.
		/// </summary>
		public Status? Status { get; set; }

		/// <summary>
		/// Represents the rollup for both the check runs and status for a commit.
		/// </summary>
		public StatusCheckRollup? StatusCheckRollup { get; set; }

		/// <summary>
		/// Represents an individual commit status context
		/// </summary>
		public StatusContext? StatusContext { get; set; }

		/// <summary>
		/// Represents a 'sub_issue_added' event on a given issue.
		/// </summary>
		public SubIssueAddedEvent? SubIssueAddedEvent { get; set; }

		/// <summary>
		/// Represents a 'sub_issue_removed' event on a given issue.
		/// </summary>
		public SubIssueRemovedEvent? SubIssueRemovedEvent { get; set; }

		/// <summary>
		/// Represents a 'subscribed' event on a given `Subscribable`.
		/// </summary>
		public SubscribedEvent? SubscribedEvent { get; set; }

		/// <summary>
		/// A team of users in an organization.
		/// </summary>
		public Team? Team { get; set; }

		/// <summary>
		/// Audit log entry for a team.add_member event.
		/// </summary>
		public TeamAddMemberAuditEntry? TeamAddMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a team.add_repository event.
		/// </summary>
		public TeamAddRepositoryAuditEntry? TeamAddRepositoryAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a team.change_parent_team event.
		/// </summary>
		public TeamChangeParentTeamAuditEntry? TeamChangeParentTeamAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a team.remove_member event.
		/// </summary>
		public TeamRemoveMemberAuditEntry? TeamRemoveMemberAuditEntry { get; set; }

		/// <summary>
		/// Audit log entry for a team.remove_repository event.
		/// </summary>
		public TeamRemoveRepositoryAuditEntry? TeamRemoveRepositoryAuditEntry { get; set; }

		/// <summary>
		/// A topic aggregates entities that are related to a subject.
		/// </summary>
		public Topic? Topic { get; set; }

		/// <summary>
		/// Represents a 'transferred' event on a given issue or pull request.
		/// </summary>
		public TransferredEvent? TransferredEvent { get; set; }

		/// <summary>
		/// Represents a Git tree.
		/// </summary>
		public Tree? Tree { get; set; }

		/// <summary>
		/// Represents an 'unassigned' event on any assignable object.
		/// </summary>
		public UnassignedEvent? UnassignedEvent { get; set; }

		/// <summary>
		/// Represents an 'unlabeled' event on a given issue or pull request.
		/// </summary>
		public UnlabeledEvent? UnlabeledEvent { get; set; }

		/// <summary>
		/// Represents an 'unlocked' event on a given issue or pull request.
		/// </summary>
		public UnlockedEvent? UnlockedEvent { get; set; }

		/// <summary>
		/// Represents an 'unmarked_as_duplicate' event on a given issue or pull request.
		/// </summary>
		public UnmarkedAsDuplicateEvent? UnmarkedAsDuplicateEvent { get; set; }

		/// <summary>
		/// Represents an 'unpinned' event on a given issue or pull request.
		/// </summary>
		public UnpinnedEvent? UnpinnedEvent { get; set; }

		/// <summary>
		/// Represents an 'unsubscribed' event on a given `Subscribable`.
		/// </summary>
		public UnsubscribedEvent? UnsubscribedEvent { get; set; }

		/// <summary>
		/// A user is an individual's account on GitHub that owns repositories and can make new content.
		/// </summary>
		public User? User { get; set; }

		/// <summary>
		/// Represents a 'user_blocked' event on a given user.
		/// </summary>
		public UserBlockedEvent? UserBlockedEvent { get; set; }

		/// <summary>
		/// An edit on user content
		/// </summary>
		public UserContentEdit? UserContentEdit { get; set; }

		/// <summary>
		/// A user-curated list of repositories
		/// </summary>
		public UserList? UserList { get; set; }

		/// <summary>
		/// A repository owned by an Enterprise Managed user.
		/// </summary>
		public UserNamespaceRepository? UserNamespaceRepository { get; set; }

		/// <summary>
		/// The user's description of what they're currently doing.
		/// </summary>
		public UserStatus? UserStatus { get; set; }

		/// <summary>
		/// A domain that can be verified or approved for an organization or an enterprise.
		/// </summary>
		public VerifiableDomain? VerifiableDomain { get; set; }

		/// <summary>
		/// A workflow contains meta information about an Actions workflow file.
		/// </summary>
		public Workflow? Workflow { get; set; }

		/// <summary>
		/// A workflow run.
		/// </summary>
		public WorkflowRun? WorkflowRun { get; set; }

		/// <summary>
		/// An executed workflow file for a workflow run.
		/// </summary>
		public WorkflowRunFile? WorkflowRunFile { get; set; }
	}
}
