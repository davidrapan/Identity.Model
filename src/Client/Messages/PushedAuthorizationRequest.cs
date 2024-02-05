using System.Collections.Generic;

namespace IdentityModel.Client;

/// <summary>
/// Request for PAR
/// </summary>
/// <seealso cref="ProtocolRequest" />
public class PushedAuthorizationRequest : ProtocolRequest, IAuthorizeRequest
{
    // TODO - Consider metadata to indicate that this is going to be signed as a JWT (for a future release)

    /// <inheritdoc />
    public string? ResponseType { get; set; }
    /// <inheritdoc />
    public string? Scope { get; set; }
    /// <inheritdoc />
    public string? RedirectUri { get; set; }
    /// <inheritdoc />
    public string? State { get; set; }
    /// <inheritdoc />
    public string? Nonce { get; set; }
    /// <inheritdoc />
    public string? LoginHint { get; set; }
    /// <inheritdoc />
    public string? AcrValues { get; set; }
    /// <inheritdoc />
    public string? Prompt { get; set; }
    /// <inheritdoc />
    public string? ResponseMode { get; set; }
    /// <inheritdoc />
    public string? CodeChallenge { get; set; }
    /// <inheritdoc />
    public string? CodeChallengeMethod { get; set; }
    /// <inheritdoc />
    public string? Display { get; set; }
    /// <inheritdoc />
    public int? MaxAge { get; set; }
    /// <inheritdoc />
    public string? UiLocales { get; set; }
    /// <inheritdoc />
    public string? IdTokenHint { get; set; }
    /// <inheritdoc />
    public string? Request { get; set; }
    /// <inheritdoc />
    public ICollection<string>? Resource { get; set; }
    /// <inheritdoc />
    public string? DPoPKeyThumbprint { get; set; }
}